'use strict';

const express = require('express');
const fs = require('fs');

// Constants
const PORT = 8080;
const HOST = '0.0.0.0';



// App
const app = express();
app.set("view engine","vash")

app.get('/', (req, res) => {

  //res.render('Step8-npm-server/index', { 
    res.render('index', { 
      title: 'Thanos is the best', 
      content:'Rest is peace ironman!'
    });

});

app.listen(PORT, HOST);
console.log(`Running on http://${HOST}:${PORT}`);