using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NUnit.Framework;

namespace KataBowlingTests
{
    public class FrameTestsShould
    {
        [TestCase("21", 3)]
        [TestCase("43", 7)]
        [TestCase("45", 9)]
        public void Give_The_Sum_Of_Bowling_Pin_Fallen_For_Basic_Frame(string frameInString, int expected)
        {
            BasicFrame basicFrame = new BasicFrame(frameInString);
            Check.That(basicFrame.GetBowlingPinFallen()).IsEqualTo(expected);
        }

        [TestCase("4/", 10)]
        [TestCase("4/", 10)]
        [TestCase("4/", 10)]
        public void Give_The_Sum_Of_Bowling_Pin_Fallen_For_Spare(string frameInString, int expected)
        {
            Frame basicFrame = new Spare(frameInString);
            Check.That(basicFrame.GetBowlingPinFallen()).IsEqualTo(expected);
        }

        [TestCase("X", 10)]
        [TestCase("X", 10)]
        [TestCase("X", 10)]
        public void Give_The_Sum_Of_Bowling_Pin_Fallen_For_Strike(string frameInString, int expected)
        {
            Frame basicFrame = new Strike(frameInString);
            Check.That(basicFrame.GetBowlingPinFallen()).IsEqualTo(expected);
        }
    }
}
