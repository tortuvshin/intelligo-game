const Player = require('../models/Player');

module.exports = {

  startGame(req, res) {
    res.render('start');
  },

  playGame(req, res) {
    res.render('game');
  },

  createPlayer(req, res){
    const player = new Player({
      name: req.body.name,
      avatar: req.body.avatar,
      score: req.body.score,
    });
    player.save((err) => {
      if (err) {
        res.send('Error: '+err);
      }
      res.send('Create new player...');
    });
  },

  showLeader(req, res){
    Player.find({}, {created : 0}, {sort: {score: 1}}, function(err, players){
      if (err) {
        res.status(404);
        res.send('Players not found!');
      }

      res.render('leader', {
        players: players,
        success: req.flash('success')
      });
    });
  }
}
