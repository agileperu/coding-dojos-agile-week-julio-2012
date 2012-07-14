namespace TennisKata.Class
{
    public class Tennis
    {
        private int score1;
        private int score2;

        private string player1;
        private string player2;

        public Tennis(string player1, string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public string Score()
        {
            if (IsDeuce())
                return "Deuce";
            if (HasWinner()) 
                return Winner() + " Wins";
            return score1.ToString() + "-" + score2.ToString();
        }
        public void Anotar(string jugador)
        {
            if (jugador == this.player1)
                score1 = IncrementarPuntaje(score1);
            else if (jugador == this.player2)
                score2 = IncrementarPuntaje(score2);
        }

        public int IncrementarPuntaje(int puntaje)
        {
            if (puntaje == 30)
                puntaje = 40;
            else
                puntaje += 15;
            return puntaje;
        }

        public bool IsDeuce()
        {
            return score1 == score2 && score1 == 40;
        }
        private bool HasWinner()
        {
            return this.score1 > 40 || score2 > 40;
        }
        private string Winner()
        {
            if (score1 > score2) 
                return this.player1;
            return this.player2;
        }
    }
}
