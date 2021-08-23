# 환경 구축하기
BMOS의 음성 인식 프로그램은 .Net Framework 4.6.1과 Python 3.x 기반으로 구현되었습니다.  
.Net Framework의 경우 Windows 10이 설치된 대부분의 컴퓨터에 기본으로 설치되어 있어 별도의 작업이 필요하지 않지만, Python과 몇몇 추가 모듈은 별도의 설치가 필요합니다.  

아래는 음성 인식 프로그램이 돌아갈 수 있는 환경을 세팅하는 방법을 설명한 글입니다.

## Python과 모듈 설치
1. 아래 글을 참고하여 파이썬을 설치합니다.  
<sub>\* 글에서 상기된 것과 같이 꼭 "Add Python 3.7 to PATH" 옵션을 체크해 주시기 바랍니다.</sub>  
[01-4 파이썬 설치하기 - 점프 투 파이썬](https://wikidocs.net/8)

2. 터미널 창을 엽니다.  
(Windows + R키를 누른 후 `cmd`를 입력하시면 터미널을 실행하실 수 있습니다.)

3. `pip install requests playsound`를 입력한 뒤 엔터를 누릅니다.


# API 키 발급/적용하기
BMOS의 음성 인식 기능을 이용하기 위해서는 API 키를 발급하여 설정하여야 합니다.  
카카오 API는 음성 인식을 위해 꼭 필요하며, 나머지는 선택 사항이므로 원하시는 경우 키를 발급받아 설정하시면 됩니다.

## 카카오 API 설정하기

1. 우선 아래 글을 참고하여 카카오 디벨로퍼즈에 로그인한 뒤 키를 발급합니다.  
[카카오 API 키 발급받기 (kakao API Key) - KADOSHoly](https://kadosholy.tistory.com/25)  
<sub>\* Web 플랫폼 등록 란에는 `http://localhost`를 입력하시면 됩니다.</sub>  
***
![image](https://user-images.githubusercontent.com/88251502/130471802-28739c67-b3e5-4e90-adb1-cb9c03bcdfd1.png)
  
  위와 같은 페이지를 볼 수 있다면 발급이 성공적으로 된 것입니다.
***
2. 좌측 메뉴의 '제품 설정' 메뉴의 '음성' 항목으로 들어가 '활성화 설정'을 ON 상태로 바꿉니다.  
  ON으로 전환하면 아래와 같이 `음성 인식, 합성 기능을 이용해 애플리케이션 조작` 라고 사용 목적을 적고 확인을 누릅니다.
  
  ![image](https://user-images.githubusercontent.com/88251502/130472278-fd094fbc-1ec7-4a64-8a5c-58cb50db7b12.png)
***
3. 이제 BMOS가 설치된 경로로 이동하여 `settings.ini`를 엽니다.  
  (파일이 없는 경우 새로 텍스트 파일을 만듭니다.)
  
![image](https://user-images.githubusercontent.com/88251502/130474557-8716263e-a15a-4857-8dae-c0525f99c818.png)
***
4. 다시 카카오 디벨로퍼즈의 앱 페이지로 돌아가 `REST API` 키를 복사하여 `kakao=` 부분에 붙여 넣습니다.

![image](https://user-images.githubusercontent.com/88251502/130475647-4db0d4dc-4c7e-4232-9e77-3a7201035a16.png)
![image](https://user-images.githubusercontent.com/88251502/130475215-03ce0a98-552b-4778-902f-bc20c5dc21ef.png)

\* 만약 파일이 없는 경우 아래 기본값을 모두 복사하여 붙여 넣으시기 바랍니다:
```
[KEYS]
kakao=
covid=

[URL]
finedust=
```
***
5. `settings.ini` 파일을 저장하고, 음성 인식 프로그램(`VoiceRecog.exe`)을 실행하여 정상적으로 인식이 되는지 확인합니다.

![image](https://user-images.githubusercontent.com/88251502/130476393-3b4aa1f8-7e65-48cd-a4c1-04bd001b63e8.png)

***
### 문제 해결
#### 파일을 찾을 수 없다는 오류가 뜹니다
- 이 경우 녹음한 음성을 전송하는데 사용되는 ffmpeg.exe가 없기 때문일 수 있습니다.  
  이 링크에서 빌드한 ffmpeg.exe를 받아 BMOS가 설치된 디렉토리에 넣거나 ffmpeg.exe를 다운로드 받아 해당 경로를 PATH에 추가하시기 바랍니다.
#### 스크립트의 설정 값을 읽는 데 실패하였다는 오류가 뜹니다.
- settings.ini가 올바르게 작성되지 않았기 때문일 수 있습니다.
  상기된 설정 기본값을 입력하고 kakao= 부분에 발급받은 API 키를 채운 뒤 다시 시도해 보시고,
  여전히 오류가 계속된다면 UTF-8 인코딩으로 저장하였는지 확인해 보시기 바랍니다.
  참조 글: [메모장 저장 할 때 UTF-8로 저장하는 법(Notepad++도 포함) - na27](https://na27.tistory.com/200)
