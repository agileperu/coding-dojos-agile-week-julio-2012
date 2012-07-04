using System;

namespace BowlingKata
{
    public class BowlingGame
    {
        private const int MaxTurns = 10;

        private readonly Turns _turns;

        public BowlingGame()
        {
            _turns = new Turns(MaxTurns);
        }

        public void Play(string turns)
        {
            _turns.Split(turns);

            Score = _turns.Score;
        }

        public int Score { get; set; }
    }
}
