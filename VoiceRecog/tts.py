from argparse import ArgumentParser
import playsound, configparser
from requests import post

settings = configparser.ConfigParser()
settings.read('settings.ini')
kakaokey = settings['KEYS']['kakao']

parser = ArgumentParser() 
parser.add_argument("-q", "--query") 
text = parser.parse_args().query

headers={
        "Authorization": "KakaoAK " + kakaokey,
        "Content-Type": "application/xml"
    }

data = '''<speak>
<voice name="WOMAN_READ_CALM">'''+text+'''</voice>
</speak>'''
body = data.encode('utf-8')

response = post("https://kakaoi-newtone-openapi.kakao.com/v1/synthesize", data=body, headers=headers)

open('voice.mp3', 'wb').write(response.content)
playsound.playsound('voice.mp3', True)
