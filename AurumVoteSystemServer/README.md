# Aurum ��ǥ �ý��� 
* ���� ���α׷� : Asp.Net Core
* Ŭ���̾�Ʈ ���α׷� : Blazor WebAssembly

- ���� ��� : dotnet publish -c Release -o ./publish_output

- ������ ���� ��Ʈ ���� : AurumVoteSystemClient\Services\VotingApiService.cs (https://localhost:5001)

- Ŭ���̾�Ʈ ������ ����
	- cd path\to\publish_output\wwwroot
	- Start-Process "powershell" -ArgumentList "Start-Process -FilePath 'explorer.exe' 'http://localhost:8000'; python -m http.server 8000"