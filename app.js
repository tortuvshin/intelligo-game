'use strict';

const express = require( 'express'),
      expressLayouts = require('express-ejs-layouts'),
      path           = require('path'),
      morgan         = require('morgan'),
      bodyParser     = require('body-parser'),
      mongoose       = require('mongoose'),
      cookieParser   = require('cookie-parser'),
      config         = require('config'),
      session        = require('express-session'),
      flash          = require('connect-flash'),
      expressValidator = require('express-validator'),
      passport       = require("passport");

const app = express();

app.set('port', process.env.PORT || 5000);
app.use(morgan('dev'));
app.use(cookieParser());
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));
app.use(express.static(path.join(__dirname, "public")));

app.set("views", path.join(__dirname, "views"));
app.set('view engine', 'ejs');
app.use(expressLayouts);

app.listen(app.get('port'), () => {
    console.log('Intelligo game is listening on port', app.get('port'));
});
