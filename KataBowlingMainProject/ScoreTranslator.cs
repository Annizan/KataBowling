using System.Text.RegularExpressions;

namespace KataBowlingMainProject
{
    public static class ScoreTranslator
    {
        public static string Format(string input)
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