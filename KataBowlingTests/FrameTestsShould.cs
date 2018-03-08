using System;
using KataBowlingMainProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NUnit.Framework;

namespace KataBowlingTests
{
    public class FrameTestsShould
    {
        [TestCase(2, 1, 3)]
        [TestCase(4, 3, 7)]
        [TestCase(4, 5, 9)]
        public void Give_The_Sum_Of_Bowling_Pin_Fallen_For_Basic_Frame(int firstRoll, int secondRoll, int expected)
        {
            BasicFrame basicFrame = new BasicFrame(firstRoll, secondRoll);
            Check.That(basicFrame.GetBowlingPinFallen()).IsEqualTo(expected);
        }

        [TestCase(4, 10)]
        [TestCase(6, 10)]
        [TestCase(8, 10)]
        public void Give_The_Sum_Of_Bowling_Pin_Fallen_For_Spare(int firstRoll, int expected)
        {
            Frame basicFrame = new Spare(firstRoll);
            Check.That(basicFrame.GetBowlingPinFallen()).IsEqualTo(expected);
        }

        public void Give_The_Sum_Of_Bowling_Pin_Fallen_For_Strike()
        {
            Frame basicFrame = new Strike();
            Check.That(basicFrame.GetBowlingPinFallen()).IsEqualTo(10);
        }

        
        public void Give_The_Score_For_BasicFrame()
        {
            Frame basicFrame = new BasicFrame(3, 4);
            Check.That(basicFrame.GetScore(3, 1)).IsEqualTo(7);
        }

        public void Give_The_Score_For_SpareFrame()
        {
            Frame basicFrame = new Spare(3);
            Check.That(basicFrame.GetScore(3, 1)).IsEqualTo(13);
        }

        public void Give_The_Score_For_StrikeFrame()
        {
            Frame basicFrame = new Strike();
            Check.That(basicFrame.GetScore(3, 1)).IsEqualTo(14);
        }


    }
}
