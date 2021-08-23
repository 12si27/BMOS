#오디오 포맷: Mono channel, 16000 Hz samplerate, 16 bit depth
print('패키지 로드 중...')

from requests import post, get
from os import system
import json, configparser, sys

try:
    settings = configparser.ConfigParser()
    settings.read('settings.ini')

    kakaokey = settings['KEYS']['kakao']
    covidkey = settings['KEYS']['covid']
    dustreq = settings['URL']['finedust']

except Exception as e:
    print('설정값 읽기 실패. settings.ini 파일을 확인하세요. (' + str(e) + ')')
    print('<res>스크립트의 설정 값을 읽는 데 실패했습니다. 설정 파일(settings.ini)이 유효한지 확인해 주세요.</res>')
    print('<return>1</return>')
    sys.exit()

def resCleanUp(data):
    s = '"finalResult","value":"'
    data = data[data.find(s)+len(s):data.find('","nBest"')]
    return data

def geturl(val):
    s="i.ytimg.com/vi/" 
    return val[val.find(s)+len(s):val.find(s)+len(s)+11]

def midReturn(val, s, e):
    if s in val:
        val = val[val.find(s)+len(s):]
        if e in val: val = val[:val.find(e)]
    return val

def pmLevel(pm10val, pm25val):
    pm10lv = 0
    pm25lv = 0

    if pm10val<=15: pm10lv = 1
    elif pm10val <= 30: pm10lv = 2
    elif pm10val <= 40: pm10lv = 3
    elif pm10val <= 50: pm10lv = 4
    elif pm10val <= 75: pm10lv = 5
    elif pm10val <= 100: pm10lv = 6
    elif pm10val <= 150: pm10lv = 7
    elif pm10val >= 151: pm10lv = 8

    if pm25val <= 8: pm25lv = 1
    elif pm25val <= 15: pm25lv = 2
    elif pm25val <= 20: pm25lv = 3
    elif pm25val <= 25: pm25lv = 4
    elif pm25val <= 37: pm25lv = 5
    elif pm25val <= 50: pm25lv = 6
    elif pm25val <= 75: pm25lv = 7
    elif pm25val >= 76: pm25lv = 8

    if pm10lv <= pm25lv: pm10lv = pm25lv

    if pm10lv == 1: lv = "최고"
    elif pm10lv == 2: lv = "좋음"
    elif pm10lv == 3: lv = "양호"
    elif pm10lv == 4: lv = "보통"
    elif pm10lv == 5: lv = "나쁨"
    elif pm10lv == 6: lv = "매우 나쁨"
    elif pm10lv == 7: lv = "극도로 나쁨"
    elif pm10lv == 8: lv = "최악"

    return lv

headers = {
    'Content-Type': 'application/octet-stream',
    'X-DSS-Service': 'DICTATION',
    'Authorization': 'KakaoAK ' + kakaokey,
}

print('오디오 스트림 파일 전송 중...')
data = open('new.wav', 'rb').read()
response = post('https://kakaoi-newtone-openapi.kakao.com/v1/recognize', headers=headers, data=data)

print(response.text)

print('리턴값 정리 중...')
res = resCleanUp(response.text)
print('<res>'+res+'</res>')

#명령문 키워드
playcmd = ['틀어줘', '노래 재생해줘', '음악 틀어줘', '음악 재생해줘', '노래 틀어', '노래 재생']
dustcmd = ['미세먼지', '미세 먼지', '대기정보', '대기 정보', '대기 상태']
srchcmd = ['검색해줘', '검색', '찾아줘', '찾기']
shellcmd = ['실행해줘','실행','열어줘','열어']
oscmd = ['컴퓨터 종료','컴퓨터 꺼','시스템 종료','전원 종료', '전원 꺼', '종료 취소', '절전', '슬립']
covidcmd = ['코로나', '코비드']

exectype = ''
url = ''

if any(cmd in res for cmd in playcmd):

    #유튜브 재생
    song = '노래' in res or '음악' in res
    exectype = 'web'
    print('유튜브 요청 보내는 중...')   

    for delkw in playcmd:
        res = res.replace(delkw, '', 1)

    print('<tts>' + res + ' 재생을 시작합니다.</tts>')

    if song: res += ' "topic"'
        
    r = get("https://www.youtube.com/results?search_query=" + res).text    
    url = 'https://www.youtube.com/embed/' + geturl(r) + '?autoplay=1' 
    
elif any(cmd in res for cmd in dustcmd):

    #미세먼지

    if '측정소' in res:
        exectype = 'tts'
        try:
            res = res.split(' ')
            i=0
            while res[i] != '측정소': i+=1

            if i != 0:
                st = res[i-1].strip()
                r = get(dustreq+st+'.xml').text

                if 'Not Found' in r:
                    print('<tts>"'+st+'" 측정소를 찾을 수 없습니다.<br>에어코리아에 접속하여 측정소를 조회해 보시기 바랍니다.</tts>')
                else:
                    stime = midReturn(r, '<dataTime>', '</dataTime>')
                    spm10 = midReturn(r, '<pm10Value>', '</pm10Value>')
                    spm25 = midReturn(r, '<pm25Value>', '</pm25Value>')

                    lv = pmLevel(int(spm10), int(spm25))
                    msg = '현재 ' + st + ' 측정소 기준 미세먼지 농도는 ' + lv + ' 상태입니다.'

                    print('<tts>'+msg+'</tts>')
            else:
                print('<tts>대기 측정소 이름을 제대로 말해주세요.</tts>')

        except:
            print('<tts>대기정보 조회중 오류가 발생했습니다. 다시 시도해 주세요.</tts>')
                       
    else:
        stationok = False
        if '미세먼지' in res:
            try:
                res = res.split(' ')
                i=0
                while res[i] != '미세먼지': i+=1

                if i != 0:
                    st = res[i-1].strip()
                    r = get(dustreq+st+'.xml').text

                    if not 'Not Found' in r:
                        exectype = 'tts'
                        stationok = True
                        stime = midReturn(r, '<dataTime>', '</dataTime>')
                        spm10 = midReturn(r, '<pm10Value>', '</pm10Value>')
                        spm25 = midReturn(r, '<pm25Value>', '</pm25Value>')

                        lv = pmLevel(int(spm10), int(spm25))
                        msg = '현재 ' + st + ' 측정소 기준 미세먼지 농도는 ' + lv + ' 상태입니다.'

                        print('<tts>' + msg + '</tts>')
            except: pass

        if not stationok:
            exectype = 'web'
            url = 'http://www.airkorea.or.kr/web'

            print('<tts>에어코리아 웹페이지로 방문합니다.</tts>')
    
elif any(cmd in res for cmd in srchcmd):

    #검색
    exectype = 'web'
    for delkw in srchcmd:
        res = res.replace(delkw, '', 1)    
    url = 'https://www.google.com/search?q=' + res

elif any(cmd in res for cmd in shellcmd):

    #실행
    exectype = 'launch'
    for delkw in shellcmd:
        res = res.replace(delkw, '', 1)    
    print('<shell>' + res.strip() + '</shell>')

    print('<tts>' + res + ' 실행을 시작합니다.</tts>')
	
elif any(cmd in res for cmd in oscmd):

    exectype='os'
    if ('종료' in res) or ('꺼' in res):
        if res=='종료 취소':
            system('shutdown -a')
            print('<tts>종료를 취소합니다.</tts>')
        else:
            system('shutdown -s -t 30 -f')
            print('<tts>30초 뒤 컴퓨터를 종료합니다. 취소를 원하시면 저를 부른 뒤 종료 취소라고 말해주세요.</tts>')
    elif ('절전' in res) or ('슬립' in res):
        print('<tts>절전 모드로 들어갑니다.</tts>')
        system('psshutdown -d -t 3')
    
elif any(cmd in res for cmd in covidcmd):
    exectype='covid'

    import json

    p = post('https://api.corona-19.kr/korea/?serviceKey=' + covidkey)
    js1 = json.loads(p.text)

    p = post('https://api.corona-19.kr/korea/country/new/?serviceKey=' + covidkey)
    js2 = json.loads(p.text)

    updTime = js1['updateTime'][js1['updateTime'].find('('):]
    
    print('<tts>현재' + updTime + ' 신규 확진자 수는 ' + js2['korea']['newCase'] + '명,\n누적 확진자 수는 ' + js2['korea']['totalCase'] + '명 입니다.</tts>')
    

if exectype == 'web':
    print('<browse>' + url + '</browse>')

if exectype == '':
    print('<return>1</return>')

else:
    print('<return>0</return>')