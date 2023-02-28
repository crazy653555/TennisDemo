using FluentAssertions;
using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void show_winner_Result()
        {
            var game = new Game();
            var player1 = new Player()
            {
                Name="Joey",
                Value = 0
            };


            var player2 = new Player()
            {
                Name="Joey",
                Value = 0
            };

            var showResult = game.ShowResult(player1, player2);

            showResult.Should().Be("All Love");
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public class Game
    {
        public string ShowResult(Player player1, Player player2)
        {
            return "All Love";
        }
    }
}