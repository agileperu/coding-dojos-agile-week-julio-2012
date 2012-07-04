using System;
using System.Collections.Generic;

namespace BowlingKata
{
    public abstract class Turn
    {
        protected readonly Turns Turns;

        protected Turn(Turns turns)
        {
            Turns = turns;
        }

        public int Puntos { get; protected set; }

        public abstract int CalculateScore();
    }

    public class Strike : Turn
    {
        public Strike(Turns turns)
            : base(turns)
        {
            Puntos = 10;
        }

        public override int CalculateScore()
        {
            int total = 10;
            int myIndex = Turns.IndexOf(this);

            total += Turns[myIndex + 1].Puntos + Turns[myIndex + 2].Puntos;
            return total;
        }
    }

    public class Spare : Turn
    {
        public Spare(Turns turns) 
            : base(turns)
        {
        }

        public override int CalculateScore()
        {
            throw new NotImplementedException();
        }
    }

    public class Miss : Turn
    {
        public Miss(Turns turns) : base(turns)
        {
        }

        public override int CalculateScore()
        {
            throw new NotImplementedException();
        }
    }

    public class Partial : Turn
    {
        public Partial(Turns turns, char number) 
            : base(turns)
        {

        }

        public override int CalculateScore()
        {
            throw new NotImplementedException();
        }
    }

}