var c, cc;

var score = 0;
var brickspeed = 0.03;
// paddle
var paddle_x_position = 0;
var paddle_height = 30;
var paddle_width = 300;
var paddle_y_position = 430

//ball
var ball_x_position = 470;
var ball_y_position = 200;
var ball_dimension = 15;
var x_velocity = 1;
var y_velocity = 1;

//brick parameters
var brickRowCount = 3;
var brickColumnCount = 6;
var brickWidth = 65;
var brickHeight = 20;
var brickPaddingX = 20;
var brickPaddingY = 10;
var brickOffsetTop = 20;
var brickOffsetLeft = 40;

var gameHasStarted = false;

//create brick array
var bricks = [];
for(c=0; c<brickColumnCount; c++) {
    bricks[c] = [];
    for(r=0; r<brickRowCount; r++) {
         bricks[c][r] = { x: 0, y: 0, status: 1 };

    }
}

var ratio = 4.8; //ratio between tracking video and canvas size

var updateRate = 5; //updates every 50 milliseconds

// Obtain video elements
var canvas = document.getElementById('canvas');
var context = canvas.getContext('2d');
var video = document.getElementById('video');

var interval_id;
