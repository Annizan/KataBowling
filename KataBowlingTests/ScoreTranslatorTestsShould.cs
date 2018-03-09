using KataBowlingMainProject;
using NFluent;
using NUnit.Framework;

namespace KataBowlingTests
{
    public class ScoreTranslatorTestsShould
    {
        [TestCase("14 14 14 14 14 14 14 14 14 14", "14 14 14 14 14 14 14 14 14 14")]
        [TestCase("14 14 14 14 14 14 14 1- 14 14", "14 14 14 14 14 14 14 10 14 14")]
        [TestCase("14 14 14 14 14 14 14 1- 14 1/5", "14 14 14 14 14 14 14 10 14 1/ 50")]
        public void Translate_Frames_Input_To_Formatted_One(string input, string expected)
        {
            var formattedString = ScoreTranslator.Format(input);
            Check.That(formattedString).IsEqualTo(expected);
        }
    }
}
