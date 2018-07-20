const game = require('../app/GameController');

module.exports = function(app){

  app.get('/', game.playGame);

  app.post('/', game.createPlayer);

  app.get('/seed', game.demoData);

}
