var container, stats;
var camera, controls, scene, renderer, sphere, pointCloud;
var brickArray = [];
var topPosition = 165;
var xPadding = 46;
var objectName = 0;
var particleName = 0;

var movementSpeed = 80;
var totalObjects = 1000;
var objectSize = 10;
var sizeRandomness = 4000;
var dirs = [];
var parts = [];


init();
animate();


function init() {
  container = document.createElement( 'div' );
  container.className = "threeElement"
  document.body.appendChild( container );
  // document.getElementsByClassName("threeElement")[0].style.display = "none"

  // Create the scene and set the scene size
  scene = new THREE.Scene();
  var WIDTH = window.innerWidth;
  var HEIGHT = window.innerHeight;

  // Create a camera, zoom it out from the model a bit
  camera = new THREE.PerspectiveCamera( 90, WIDTH / HEIGHT, 1, 10000 );
  camera.position.z = 200;
  camera.position.y = -35;

  // Create AudioListener
  var listener = new THREE.AudioListener()
  camera.add(listener);

  // Create global audio source
  var sound = new THREE.Audio( listener );
  var audioLoader = new THREE.AudioLoader();

  audioLoader.load( '../js/sounds/song.mp3', function( buffer ) {
	sound.setBuffer( buffer );
	sound.setLoop(true);
	sound.setVolume(0.5);
	sound.play();
});

  // Create and ambient light
  ambLight = new THREE.AmbientLight( 0xcd950c )
  scene.add( ambLight );

  // Create a spot light
  var sptlight = new THREE.SpotLight( 0xffffff, 0.85 );
  sptlight.position.set( 0, -2500, 10000 );
  sptlight.castShadow = true;
  sptlight.shadow = new THREE.LightShadow( new THREE.PerspectiveCamera( 50, 1, 200, 10000 ) );
  sptlight.shadow.bias = - 0.00022;
  sptlight.shadow.mapSize.width = 2048;
  sptlight.shadow.mapSize.height = 2048;
  scene.add( sptlight );

  // This allows the user to move the camera with the mouse
  controls = new THREE.TrackballControls( camera );
  controls.rotateSpeed = 1.0;
  controls.zoomSpeed = 1.2;
  controls.panSpeed = 0.8;
  controls.noZoom = false;
  controls.noPan = false;
  controls.staticMoving = true;
  controls.dynamicDampingFactor = 0.3;

  // Create a sphere geometry with materials and Mesh
  // var geometry = new THREE.TetrahedronGeometry( 95, 3);
  var geometry = new THREE.TetrahedronGeometry(13, 1);
  var material = new THREE.MeshPhongMaterial({
    color: 0x33d6ff,
    shininess:0,
    specular:0xffffff,
    shading:THREE.FlatShading
  });
  sphere = new THREE.Mesh( geometry, material );
  sphere.position.x = 0
  sphere.position.z = 0
  sphere.position.y = 120
  sphere.castShadow = true;
  sphere.receiveShadow = true;
  scene.add( sphere );

  // Create a rectangle geometry
  var geometry = new THREE.BoxGeometry(40, 10, 8);

  // For loop that creates each object on the first row with a random color
  for ( var i = 0; i < 12; i ++ ) {
    var material = new THREE.MeshPhongMaterial( { color: Math.random() * 0xffffff } )
    var object = new THREE.Mesh( geometry, material);
    object.position.x = -252 + (i*xPadding);
    object.position.y = topPosition + 60;
    object.position.z = 0;
    object.castShadow = true;
    object.receiveShadow = true;
    object.status = 1;
    object.row = 1;
    object.name = objectName.toString();
    object.isPowerup = 0;
    objectName++;
    scene.add( object );
    brickArray.push( object );
  }

  // For loop that creates each object on the second row with a random color
  for ( var i = 0; i < 10; i ++ ) {
    var material = new THREE.MeshPhongMaterial( { color: Math.random() * 0xffffff, name: 'object' + i } )
    var object = new THREE.Mesh( geometry, material);
    object.position.x = -205 + (i*xPadding);
    object.position.y = topPosition+30;
    object.position.z = 0;
    object.castShadow = true;
    object.receiveShadow = true;
    object.status = 1;
    object.isPowerup = 0;
    object.row = 2;
    object.name = objectName.toString();
    objectName++;
    scene.add( object );
    brickArray.push( object );
  }

  // For loop that creates each object on the third row with a random color
  for ( var i = 0; i < 11; i ++ ) {
    var material = new THREE.MeshPhongMaterial( { color: Math.random() * 0xffffff } )
    var object = new THREE.Mesh( geometry, material);
    object.position.x = -238 + (i*(xPadding+1));
    object.position.y = topPosition;
    object.position.z = 0;
    object.castShadow = true;
    object.receiveShadow = true;
    object.isPowerup = 0;
    object.status = 1;
    object.row = 3;
    object.name = objectName.toString();
    objectName++;
    scene.add( object );
    brickArray.push( object );
  }

  // Renders everything

  renderer = new THREE.WebGLRenderer( { alpha: true } );
  renderer.setClearColor( 0xb8e9f2, 0);
  renderer.setPixelRatio( window.devicePixelRatio );
  renderer.setSize( WIDTH, HEIGHT ); //set the width and height of rendered
  renderer.sortObjects = false;
  renderer.shadowMap.enabled = true;
  container.appendChild( renderer.domElement );


  window.addEventListener( 'resize', onWindowResize, false );

}
// END OF INIT FUNCTION

// RESIZES THE RENDERER WITH THE BROWSER WINDOW
function onWindowResize() {
  camera.aspect = WIDTH / HEIGHT;
  camera.updateProjectionMatrix();
  renderer.setSize( WIDTH, HEIGHT );
}

function ExplodeAnimation(x,y) {
  var geometry = new THREE.Geometry();

  for (i = 0; i < totalObjects; i ++) {
    var vertex = new THREE.Vector3();
    vertex.x = x;
    vertex.y = y;
    vertex.z = 0;

    geometry.vertices.push( vertex );
    dirs.push({x:(Math.random() * movementSpeed)-(movementSpeed/2),y:(Math.random() * movementSpeed)-(movementSpeed/2),z:(Math.random() * movementSpeed)-(movementSpeed/2)});
  }
  var material = new THREE.PointsMaterial( { size: objectSize,  color: colors[Math.round(Math.random() * colors.length)] });
  var particles = new THREE.Points( geometry, material );

  this.object = particles;
  this.status = true;

  this.xDir = (Math.random() * movementSpeed)-(movementSpeed/2);
  this.yDir = (Math.random() * movementSpeed)-(movementSpeed/2);
  this.zDir = (Math.random() * movementSpeed)-(movementSpeed/2);

  scene.add( this.object  );

  this.update = function(){
    if (this.status == true){
      var pCount = totalObjects;
      while(pCount--) {
        var particle =  this.object.geometry.vertices[pCount]
        particle.y += 2*dirs[pCount].y;
        particle.x += 2*dirs[pCount].x;
        particle.z += 2*dirs[pCount].z;
      }
      this.object.geometry.verticesNeedUpdate = true;
    }
  }

}


function addRow () {
  var geometry = new THREE.BoxGeometry(40, 10, 8);
  for ( var i = 0; i < 12; i ++ ) {
    const num = Math.random();
    if(num < 0.7 ){
      var material = new THREE.MeshPhongMaterial( { color: Math.random() * 0xffffff } )
      var object = new THREE.Mesh( geometry, material);
      object.position.x = -252 + (i*xPadding);
      object.position.y = topPosition + 60;
      object.position.z = 0;
      object.castShadow = true;
      object.receiveShadow = true;
      object.status = 1;
      object.row = 1;
      object.isPowerup = 0;
      object.name = objectName.toString();
      objectName++;
      // console.log(object)
      scene.add( object );
      brickArray.push( object );
    } else if (num < 0.77){
      let geometry = new THREE.TorusGeometry( 10, 3, 16, 100 );
      let material = new THREE.MeshToonMaterial( { color: Math.random() * 0xffffff } );
      let torus = new THREE.Mesh( geometry, material );
      torus.position.x = -252 + (i*xPadding);
      torus.position.y = topPosition + 60;
      torus.position.z = 0;
      torus.rotation.z = 0.5;
      torus.status = 1;
      torus.isPowerup = 1;
      torus.name = objectName.toString();
      brickArray.push( torus );
      scene.add( torus );
    }
  }

}

// Create the animate function
function animate() {
  requestAnimationFrame( animate )
  render();
}


// Create the render function
function render() {
  // controls.update();
  sphere.rotation.x += 0.05;
  sphere.rotation.y += 0.01;
  sphere.position.x = -(ball_x_position/1.85)+270
  sphere.position.y = -(ball_y_position/1.85)+215

  var pCount = parts.length;
    while(pCount--) {
      parts[pCount].update();
    }
  renderer.render( scene, camera);
}

document.getElementById("start_game_btn").addEventListener('click', function(){
  gameHasStarted = true;
  setTimeout(updateSpeed, 5000)
  interval_id = setInterval(addRow, 3000);
  // document.getElementsByClassName("start_game_menu")[0].style.display = "none";
  document.getElementsByClassName("start_game_menu")[0].className += " animated fadeOutUp";

  document.getElementsByClassName("game_screen")[0].style.display = "block";
  document.getElementsByClassName("score-container")[0].style.display = "block";
  var item = document.getElementById("fourth-text")
  item.className = "fourth-text"
})
