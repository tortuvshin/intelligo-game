const mongoose = require('mongoose'),
  Schema = mongoose.Schema;

const playerSchema = new Schema({
  name: String,
  avatar: String,
  avatar: String,
  score: Number,
  created: {
    type: Date,
    default: Date.now
  }
});

const playerModel = mongoose.model('Player', playerSchema);

module.exports = playerModel;
