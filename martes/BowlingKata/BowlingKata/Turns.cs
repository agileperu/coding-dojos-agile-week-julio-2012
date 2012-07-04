using System.Collections.Generic;

namespace BowlingKata
{
    public class Turns : List<Turn>
    {
        private readonly int _size;

        public Turns(int size)
        {
            _size = size;
        }

        public void Split(string turns)
        {
            for (int i = 0; i < turns.Length; i++)
            {
                if (turns[i] == 'X')
                    Add(new Strike(this));
                else if (turns[i] == '/')
                    Add(new Spare(this));
                else if (turns[i] == '-')
                    Add(new Miss(this));
                else
                    Add(new Partial(this, turns[i]));
            }

            for (int i = 0; i < _size; i++)
            {
                Score += this[i].CalculateScore();
            }
        }

        public int Score { get; set; }
    }
}