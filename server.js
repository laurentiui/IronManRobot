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

    //console.log(req);
    //console.log(res);

//   var content = fs.readFileSync('index.html');
//   res.write(content);
//   res.end();

  //res.send('Hello world\n');

  res.render('test/index2', { 
      title: 'Vash Template Demo', 
      content:'This is dummy paragraph.'
    });

});

app.listen(PORT, HOST);
console.log(`Running on http://${HOST}:${PORT}`);