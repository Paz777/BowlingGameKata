using NUnit.Framework;
using FluentAssertions;

namespace BowlingGame.Tests;

public class Tests
{
    private Game game;
    private Bowler player1;

    [SetUp]
    public void Setup()
    {
        game = new Game();
        player1 = new Bowler();
    }

    [Test]
    public void For_A_Game_Calculate_Total_Score()
    {
        game.CalculateTotalScore().Should().Be(75);
    }

    [Test]
    public void Given_A_Bowler_That_Rolls_Twice_Caculates_Total_Score()
    {
        player1.Roll(4);
        player1.Roll(6);
        player1.TotalScore.Should().Be(10);
    }
}