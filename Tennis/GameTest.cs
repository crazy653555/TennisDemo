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
            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 0
            }, new Player()
            {
                Name = "Tom",
                Value = 0
            }, "Love All");

            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 1
            }, new Player()
            {
                Name = "Tom",
                Value = 1
            }, "Fifteen All");

            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 2
            }, new Player()
            {
                Name = "Tom",
                Value = 2
            }, "Thirty All");

            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 3
            }, new Player()
            {
                Name = "Tom",
                Value = 3
            }, "Forty All");
        }


        [Test]
        public void DeuceTests()
        {
            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 4
            }, new Player()
            {
                Name = "Tom",
                Value = 4
            }, "Deuce");

            ComparerResult(new Player()
            {
                Name = "Joey",
                Value = 5
            }, new Player()
            {
                Name = "Tom",
                Value = 5
            }, "Deuce");
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
                Value = 3
            }, new Player()
            {
                Name = "Tom",
                Value = 4
            }, "Tom Adv");

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