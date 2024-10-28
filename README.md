# Aurum 투표 시스템 
* 서버 프로그램 : Asp.Net Core
* 클라이언트 프로그램 : Blazor WebAssembly

- 배포 명령 : dotnet publish -c Release -o publish_output

- 배포시 실제 포트 적용 : AurumVoteSystemClient\Services\VotingApiService.cs (https://localhost:5001)

- 클라이언트 웹서버 실행
	- cd path\to\publish_output\wwwroot
	- Start-Process "powershell" -ArgumentList "Start-Process -FilePath 'explorer.exe' 'http://localhost:8000'; python -m http.server 8000"

---
### 1. 압축 해제후 /Bin/StartServer.bat 실행 후 /Bin/StartClient.bat로 웹서버 구동
### 2. 클라이언트 테스트 실행시 웹서버 실행 후 http://localhost:8000/ 접속..
---

![image](https://github.com/user-attachments/assets/1b381b9b-0aa0-48ad-b4c1-1b4734e85ddf)

![image](https://github.com/user-attachments/assets/63a98256-60fa-4f72-9662-d1031f98f25c)

![image](https://github.com/user-attachments/assets/da5f323d-da20-4675-a21b-2c499aae654b)

---

![image](https://github.com/user-attachments/assets/1e77a8ed-60fa-42fd-9995-90a4441d7a26)

![image](https://github.com/user-attachments/assets/05f431b2-324e-40f6-a467-335920a05a1e)



