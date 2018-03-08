using System.Text.RegularExpressions;
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
            ScoreTranslator  translator = new ScoreTranslator();
            var formattedString = translator.Format(input);
            Check.That(formattedString).IsEqualTo(expected);
        }
    }

    public class ScoreTranslator
    {
        public string Format(string input)
        {

            if (Regex.IsMatch(input, "/[^ ]"))
            {
                var match = Regex.Match(input, "/[^ ]");
                input = input.Insert(match.Index + 1, " ") + "0";
            }

            input = input.Replace('-', '0');

            return input;
        }
    }
}
