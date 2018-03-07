using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace KataBowlingTests
{
    public class ScoreTranslatorTestsShould
    {
        [TestCase("14 14 14 14 14 14 14 14 14 14", "14 14 14 14 14 14 14 14 14 14")]
        [TestCase("14 14 14 14 14 14 14 1- 14 14", "14 14 14 14 14 14 14 10 14 14")]
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

            return input.Replace('-','0');
        }
    }
}
