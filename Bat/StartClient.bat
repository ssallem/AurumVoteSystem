
@echo off
cd ..\AurumVoteSystemClient\publish_output\wwwroot
powershell -Command "Start-Process 'powershell' -ArgumentList 'Start-Process -FilePath \"explorer.exe\" \"http://localhost:8000\"; python -m http.server 8000'"