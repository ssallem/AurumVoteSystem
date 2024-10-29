# Aurum 투표 시스템 
* 서버 프로그램 : Asp.Net Core
* 클라이언트 프로그램 : Blazor WebAssembly

🎯 각각 배포(publish) 명령 

```shell
dotnet publish -c Release -o publish_output
```

- 배포시 실제 포트 적용 : AurumVoteSystemClient\Services\VotingApiService.cs (https://localhost:5001)

🎯 클라이언트 웹서버 실행

```shell
cd path\to\publish_output\wwwroot
Start-Process "powershell" -ArgumentList "Start-Process -FilePath 'explorer.exe' 'http://localhost:8000'; python -m http.server 8000"
```	

---
### 1. 압축 해제후 csharp/Bat/StartServer.bat 실행 
### 2. csharp/Bat/StartClient.bat로 웹서버 구동
### 3. 클라이언트 테스트 실행시 웹서버 실행 후 http://localhost:8000/ 접속..
---

![image](https://github.com/user-attachments/assets/e7b1ccf4-fed7-4a47-a436-c5f63c2df066)

![image](https://github.com/user-attachments/assets/2d206f2c-ea74-45ae-a360-677a505f1298)

![image](https://github.com/user-attachments/assets/bfeb6ce6-4b6c-44be-a28e-b6b7ca5447c3)

---
![image](https://github.com/user-attachments/assets/c496b276-bd6e-45b6-b99d-5f263d71db41)

![image](https://github.com/user-attachments/assets/fc2e4118-916a-4f38-8143-5dde610fa558)

---

