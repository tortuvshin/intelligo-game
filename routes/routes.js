const game = require('../app/GameController');

module.exports = function(app){

  app.get('/', game.startGame);

  app.get('/play', game.playGame);

  app.get('/seed', game.demoData);

  app.get('/leader',  game.showLeader);
}
