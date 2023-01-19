#docker build -t vela_mongo . -f ./image_mongo
#docker volume create mongodata
docker build -t vela_mysql . -f ./image_mysql
Read-Host -Prompt "Images built Press Enter to exit" 