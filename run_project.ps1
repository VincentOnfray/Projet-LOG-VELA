#Run Mysql docker
cd  Docker/
.\_run_docker_compose.ps1



#Run Micro service auth

Start-Process PowerShell -argument  'cd ../MicroServiceAuth/;npx nodemon server.ts'

#Start-Process PowerShell -argument  'cd ../Middleware/;npx nodemon server.ts'

cd ../Csharp/gestion_utilisateur_vela/bin/Debug/
.\gestion_utilisateur_vela.exe

Read-Host -Prompt "Script OVER" 