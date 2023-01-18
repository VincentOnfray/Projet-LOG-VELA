echo hi
cd /usr/custom
sql=`cat populate_mysql.sql`

mysql -u root -pvela <<EOF
`echo $sql`
EOF





