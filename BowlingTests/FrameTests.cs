using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bowling.UnitTest
{
    [TestClass]
    public class FrameTests
    {
        Round round;

       

        [TestMethod]
        public void AllZero()
        {
            round = new Round();

            for (int i = 0; i < 20; i++)
            {
                round.Roll(0);
            }

            int score = round.Score();
            Assert.AreEqual(0, score);
        }
    }
}
