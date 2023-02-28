using System.Runtime.Serialization;
using FluentAssertions;
using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    public class GameTests
    {
        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        public void LoveAllTests()
        {
            var player1 = new Player()
            {
                Name = "Joey",
                Value = 0
            };

            var player2 = new Player()
            {
                Name = "Tom",
                Value = 0
            };

            var showResult = _game.ShowResult(player1, player2);

            showResult.Should().Be("Love All");
        }


        [Test]
        public void FifteenAllTests()
        {
            var player1 = new Player()
            {
                Name = "Joey",
                Value = 1
            };

            var player2 = new Player()
            {
                Name = "Tom",
                Value = 1
            };

            var showResult = _game.ShowResult(player1, player2);

            showResult.Should().Be("Fifteen All");
        }


        [Test]
        public void ThirtyAllTests()
        {
            var player1 = new Player()
            {
                Name = "Joey",
                Value = 2
            };

            var player2 = new Player()
            {
                Name = "Tom",
                Value = 2
            };

            var showResult = _game.ShowResult(player1, player2);

            showResult.Should().Be("Thirty All");
        }

        [Test]
        public void FortyAllTests()
        {
            var player1 = new Player()
            {
                Name = "Joey",
                Value = 3
            };

            var player2 = new Player()
            {
                Name = "Tom",
                Value = 3
            };

            var showResult = _game.ShowResult(player1, player2);

            showResult.Should().Be("Forty All");
        }

        [Test]
        public void DeuceTests()
        {
            var player1 = new Player()
            {
                Name = "Joey",
                Value = 4
            };

            var player2 = new Player()
            {
                Name = "Tom",
                Value = 4
            };

            var showResult = _game.ShowResult(player1, player2);

            showResult.Should().Be("Deuce");
        }


        [Test]
        public void ComparerTests()
        {
            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 1
            }, new Player()
            {
                Name = "Tom",
                Value = 0
            }, "Fifteen Love");

            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 2
            }, new Player()
            {
                Name = "Tom",
                Value = 3
            }, "Thirty Forty");


            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 4
            }, new Player()
            {
                Name = "Tom",
                Value = 3
            }, "Joey Adv");


            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 5
            }, new Player()
            {
                Name = "Tom",
                Value = 6
            }, "Tom Adv");


            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 5
            }, new Player()
            {
                Name = "Tom",
                Value = 7
            }, "Tom Win");
            
            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 7
            }, new Player()
            {
                Name = "Tom",
                Value = 5
            }, "Joey Win");
        }

        private void ComparerResult(Player player1, Player player2, string output)
        {
            var showResult = _game.ShowResult(player1, player2);

            showResult.Should().Be(output);
        }
    }
}