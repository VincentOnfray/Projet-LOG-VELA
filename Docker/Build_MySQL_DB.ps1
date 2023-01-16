docker exec -it docker-mysql_db-1 sh /usr/custom/build_mysql_db.sh
Start-Sleep -Seconds 3
docker container restart docker-mysql_db-1
Read-Host -Prompt "Press Enter to exit"