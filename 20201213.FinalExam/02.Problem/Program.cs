using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})\]";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    NewMessage(match);
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
        private static void NewMessage(Match match)
        {
            string command = match.Groups["command"].Value;
            string message = match.Groups["message"].Value;
            List<int> encrypt = new List<int>();
            foreach (var item in message)
            {
                encrypt.Add(item);
            }
            string result = string.Join(" ", encrypt);
            Console.WriteLine($"{command}: {result}");
        }
    }
}