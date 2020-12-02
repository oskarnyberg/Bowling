using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bowling.UnitTest
{
    [TestClass]
    public class FrameTests
    {
        Round r;

        public FrameTests()
        {
            r = new Round();
        }

        private void RollBalls(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                r.Roll(pins);
            }
        }

        [TestMethod]
        public void OneGutterBall()
        {
            RollBalls(1, 0);
            Assert.AreEqual(0, r.Score());
        }

        [TestMethod]
        public void AllGutterBalls()
        {
            RollBalls(20, 0);
            Assert.AreEqual(0, r.Score());
        }

        [TestMethod]
        public void TwentyOnePinBalls()
        {
            RollBalls(20, 1);
            Assert.AreEqual(20, r.Score());
        }
    }
}
