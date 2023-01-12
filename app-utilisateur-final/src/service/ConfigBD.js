const express = require('express');
const mysql = require('mysql2');
const app = express();

const connection = mysql.createConnection({
    host: 'your_host',
    user: 'your_user',
    password: 'your_password',
    database: 'your_db'
});

connection.connect((err) => {
    if (err) {
        return console.error('error: ' + err.message);
    }
    console.log('Connected to the MySQL server.');
});

app.get('/data', (req, res) => {
  connection.query('SELECT * FROM your_table', (err, rows, fields) => {
    if (!err)
      res.send(rows);
    else
      console.log(err);
  });
});

app.listen(3000, () => {
    console.log('Server is listening on port 3000');
});
