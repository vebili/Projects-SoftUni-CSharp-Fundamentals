using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})\]";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    DecryptTheMessage(match);

                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
        private static void DecryptTheMessage(Match match)
        {
            string command = match.Groups["command"].Value;
            List<int> decrypted = new List<int>();
            string message = match.Groups["message"].Value;
            foreach (var item in message)
            {
                int current = (int)item;
                decrypted.Add(current);
            }
            string result = string.Join(" ", decrypted);
            Console.WriteLine($"{command}: {result}");
        }
    }
}