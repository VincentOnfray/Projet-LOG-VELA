.\_build_images.ps1
.\_run_docker_compose.ps1
Write-Host "Giving servers time to boot" 
Start-Sleep -Seconds 4
.\Build_MySQL_DB.ps1
.\MySQLbash.ps1
Read-Host -Prompt "PIPELINE OVER" 