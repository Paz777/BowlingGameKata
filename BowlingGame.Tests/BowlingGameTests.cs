using NUnit.Framework;
using FluentAssertions;

namespace BowlingGame.Tests;

public class Tests
{
    private Game game;
    [SetUp]
    public void Setup()
    {
        game = new Game();
    }

    [Test]
    public void For_A_Game_Calculate_Total_Score()
    {
        game.CalculateTotalScore().Should().Be(75);
    }
}