using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataBowlingMainProject;
using NFluent;
using NUnit.Framework;

namespace KataBowlingTests
{
    class ScoreManagerTestsShould
    {

        [TestCase("12 12 12 12 12 12 12 12 12 12", 30)]
        [TestCase("15 13 53 34 -- 81 15 17 -2 12", 53)]
        [TestCase("14 14 5/ 14 14 41 14 14 32 32", 56)]
        [TestCase("14 14 5/ 14 14 X 14 14 32 32", 66)]
        [TestCase("14 14 5/ 14 14 X 14 14 32 3/5", 76)]
        [TestCase("14 14 5/ 14 14 X 14 14 32 X 53", 79)]
        [TestCase("14 14 5/ 14 14 X 14 14 32 X X 3", 84)]
        [TestCase("X X X X X X X X X X X X", 300)]
        [TestCase("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5", 150)]
        public void Give_The_Score_When_Giving_A_String_Of_Frames(string framesString, int expected)
        {
            var scoreCalculator = new ScoreManager();
            Check.That(scoreCalculator.Calculate(framesString)).IsEqualTo(expected);
        }
    }
}
