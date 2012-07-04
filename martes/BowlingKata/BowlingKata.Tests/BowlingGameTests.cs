using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class BowlingGameTests
    {
        private BowlingGame _game;

        [SetUp]
        public void SetUpGame()
        {
            // Arrange
            _game = new BowlingGame();
        }

        [Test]
        public void DoceIntentosDoceStrikes()
        {
            // Act
            _game.Play("XXXXXXXXXXXX");
            // Assert
            Assert.AreEqual(300, _game.Score);
        }

        [Test]
        public void VeinteIntentosDiezParesDeNueveYNada()
        {
            // Act
            _game.Play("9-9-9-9-9-9-9-9-9-9-");
            // Assert
            Assert.AreEqual(90, _game.Score);
        }

        [Test]
        public void VeintiunIntentosDioezParesdeCincoYSpareMasCinco()
        {
            // Act
            _game.Play("5/5/5/5/5/5/5/5/5/5/5");
            // Assert
            Assert.AreEqual(150, _game.Score);
        }



    }
}
