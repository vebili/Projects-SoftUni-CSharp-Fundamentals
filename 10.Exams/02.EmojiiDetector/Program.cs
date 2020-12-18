using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.EmojiiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(:{2}|\*{2})(?<emojiName>[A-Z][a-z]{2,})\1";
            string digitPattern = @"\d";

            string inputText = Console.ReadLine();

            List<string> coolEmojis = new List<string>();
            long coolThresholdSum = 1;
            int countOfAllEmojis = 0;

            MatchCollection matches = Regex.Matches(inputText, pattern);
            MatchCollection digitMatches = Regex.Matches(inputText, digitPattern);

            foreach (Match digit in digitMatches)
            {
                coolThresholdSum *= int.Parse(digit.Value);
            }

            foreach (Match match in matches)
            {
                string name = match.Groups["emojiName"].Value;
                int sumNameAsDigits = 0;
                countOfAllEmojis++;

                for (int i = 0; i < name.Length; i++)
                {
                    char currentChar = name[i];
                    sumNameAsDigits += currentChar;
                }

                if (sumNameAsDigits > coolThresholdSum)
                {
                    coolEmojis.Add(match.Value);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{countOfAllEmojis} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", coolEmojis));
        }
    }
}