'use strict';

const express = require( 'express'),
      expressLayouts = require('express-ejs-layouts'),
      path           = require('path'),
      morgan         = require('morgan'),
      mongoose       = require('mongoose'),
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

mongoose.Promise = global.Promise;
mongoose.connect('mongodb://127.0.0.1:27017/intelligo', { useNewUrlParser: true });

const db = mongoose.connection;
db.on('error', console.error.bind(console, 'connection error:'));
db.once('open', function() {
  console.log("Database connected");
});

require('./routes/routes.js')(app);

app.listen(app.get('port'), () => {
    console.log('Intelligo game is listening on port', app.get('port'));
});
