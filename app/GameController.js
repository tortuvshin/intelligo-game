const Player = require('../models/Player');

module.exports = {

  playGame(req, res) {
    Player.find({}, {created : 0}, {sort: {score: -1}}, function(err, players){
      if (err) {
        res.status(404);
        res.send('Players not found!');
      }

      res.render('game', {
        players: players
      });
    });
  },

  demoData(req, res){
    const players = [
      { name: "Doljko", avatar: "demo/url.jpg", score: 1233 },
      { name: "Toroo", avatar: "demo/url.jpg", score: 456 },
      { name: "Ganaa", avatar: "demo/url.jpg", score: 233 },
      { name: "Demo", avatar: "demo/url.jpg", score: 342 },
      { name: "Naraa", avatar: "demo/url.jpg", score: 545 },
      { name: "Boldoo", avatar: "demo/url.jpg", score: 564 }
    ];

    Player.remove({}, () => {
      for (player of players) {
        const newPlayer = new Player(player);
        newPlayer.save();
      }
    });

    res.send('Players demo data seeded!');
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
  }
}
