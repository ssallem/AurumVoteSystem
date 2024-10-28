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
