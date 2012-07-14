using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata.Tests
{
    using TennisKata.Class;

    [TestClass]
    public class TennisTests
    {
        private Tennis tennis = new Tennis("Pedro", "Juan");

        [TestMethod]
        public void CuandoUnJuegoComienzaLosJugadoresEstanEmpatados()
        {

            var score = tennis.Score();

            Assert.AreEqual("0-0", score);
        }

        [TestMethod]
        public void JugadorUnoAnotaPunto()
        {
            anotarJugadores(1, 0);
            var score = tennis.Score();

            Assert.AreEqual("15-0", score);

        }

        [TestMethod]
        public void JugadorDosAnotaPunto()
        {
            anotarJugadores(0, 1);
            var score = tennis.Score();

            Assert.AreEqual("0-15", score);
        }

        [TestMethod]
        public void JugadorUnoAnotaDosVeces()
        {
          anotarJugadores(2, 0);
            
            var score = tennis.Score();
          
            Assert.AreEqual("30-0", score);
        }

        [TestMethod]
        public void JugadorDosAnotaDosVeces()
        {
            anotarJugadores(0, 2);
            var score = tennis.Score();

            Assert.AreEqual("0-30", score);
        }

        [TestMethod]
        public void JugadorUnoYDosAnotan()
        {
            anotarJugadores(1,1);

            Assert.AreEqual("15-15", tennis.Score());
        }

        [TestMethod]
        public void JugadorUnoNotacion3Veces()
        {
            anotarJugadores(3, 0);

            Assert.AreEqual("40-0", tennis.Score());
        }

        [TestMethod]
        public void JugadorDosNotacion3Veces()
        {
            anotarJugadores(0, 3);

            Assert.AreEqual("0-40", tennis.Score());
        }

        [TestMethod]
        public void JugadorUnoYDosEnDeuce()
        {
            anotarJugadores(3, 3);

            Assert.AreEqual("Deuce", tennis.Score());
        }

        [TestMethod]
        public void JugadorUnoGanaSiAnota4Veces()
        {
            anotarJugadores(4, 0);

            Assert.AreEqual("Pedro Wins", tennis.Score());
        }

        [TestMethod]
        public void JugadorDosGanaSiAnota4Veces()
        {
            anotarJugadores(0, 4);

            Assert.AreEqual("Juan Wins", tennis.Score());
        }

        public void anotarJugadores(int veces, int veces2)
        {
            for (int i = 0; i < veces; i++)
            {
                tennis.Anotar("Pedro");    
            }
            for (int i = 0; i < veces2; i++)
            {
                tennis.Anotar("Juan");
            }
            
        }
    }

}

