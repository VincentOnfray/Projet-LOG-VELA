echo hi
cd /usr/custom
sql=`cat build_mysql_db_script.sql`

mysql -u root -pvela <<EOF
`echo $sql`
EOF


file="/etc/my.cnf"





