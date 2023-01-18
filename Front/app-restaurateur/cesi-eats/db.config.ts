const express = require('express');
const mysql = require('mysql2');
const app = express();
import { DataSource } from "typeorm";
/*const connection = mysql.createConnection({
    host: 'localhost',
    user: 'bd',
    password: 'bede',
    database: 'testdev',
    port:"3306"
});*/
export const AppDataSource = new DataSource ({
    type: "mysql",
    host: "localhost",
    port: 3306,
    username: "bd",
    password: "bede",
    database: "testdev"
})
/*
AppDataSource.connect((err) => {
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
})*/