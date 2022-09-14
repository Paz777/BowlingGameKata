using System;
namespace BowlingGame
{
    public class Bowler
    {
        public int TotalScore;

        public Bowler()
        {
        }

        public void Roll(int score)
        {
           TotalScore += score;
        }
    }
}

