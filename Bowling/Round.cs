using System;

namespace Bowling
{
    public class Round
    {
        public int[] rolls = new int[20];
        public int[] frame = new int[10];
        int currentRoll = 0;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int frameNumber = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                score += rolls[frameNumber] + rolls[frameNumber + 1];
                frameNumber += 2;
            }

            return score;
        }
    }
}
