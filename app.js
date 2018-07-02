'use strict';

const express = require( 'express'),
      expressLayouts = require('express-ejs-layouts'),
      path           = require('path'),
      morgan         = require('morgan'),
      bodyParser     = require('body-parser');

const app = express();

app.set('port', process.env.PORT || 5000);
app.use(morgan('dev'));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));
app.use(express.static(path.join(__dirname, "public")));

app.set("views", path.join(__dirname, "views"));
app.set('view engine', 'ejs');
app.use(expressLayouts);
app.get('/', function(req, res) {
    res.render('user.ejs');
});
app.listen(app.get('port'), () => {
    console.log('Intelligo game is listening on port', app.get('port'));
});
