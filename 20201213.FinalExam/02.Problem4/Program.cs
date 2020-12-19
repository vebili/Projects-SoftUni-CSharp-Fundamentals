using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mirorWords = new List<string>();
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(@|#)(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1");

            MatchCollection words = pattern.Matches(input);
            int counter = 0;

            foreach (Match match in words)
            {
                if (match.Success)
                {
                    string firstWord = match.Groups["first"].Value;
                    string secondWord = match.Groups["second"].Value;
                    char[] secondToChar = secondWord.ToCharArray();
                    Array.Reverse(secondToChar);
                    string secondReversed = new string(secondToChar);

                    if (firstWord == secondReversed)
                    {
                        string miror = firstWord + " <=> " + secondWord;
                        mirorWords.Add(miror);
                    }
                    counter++;
                }
            }
            if (words.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{counter} word pairs found!");
            }
            if (mirorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirorWords));
            }
        }
    }
}