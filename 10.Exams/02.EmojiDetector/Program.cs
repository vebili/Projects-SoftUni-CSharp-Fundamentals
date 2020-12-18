using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"([\:\:]{2})(?<animal1>[A-Z][a-z]{2,})([\:\:]{2})|([\*\*]{2})(?<animal2>[A-Z][a-z]{2,})([\*\*]{2})";
            string thresholdPattern = @"\d";
            string input = Console.ReadLine();
            Regex emojiRegEx = new Regex(emojiPattern);
            Regex thresholdRegEx = new Regex(thresholdPattern);
            MatchCollection threshold = thresholdRegEx.Matches(input);
            MatchCollection emojis = emojiRegEx.Matches(input);
            BigInteger coolThresh = new BigInteger(1);
            int sum = 0;
            foreach (Match number in threshold)
            {
                coolThresh *= int.Parse(number.Value);
            }
            Console.WriteLine($"Cool threshold: {coolThresh}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            foreach (Match emoji in emojis)
            {
                string currentEmoji = emoji.Value;
                foreach (var ch in currentEmoji)
                {
                    if (char.IsLetter(ch))
                    {
                        int asciiCode = ch;
                        sum += asciiCode;
                    }
                }
                if (sum >= coolThresh)
                {
                    Console.WriteLine(emoji.Value);
                }
                sum = 0;
            }
        }
    }
}