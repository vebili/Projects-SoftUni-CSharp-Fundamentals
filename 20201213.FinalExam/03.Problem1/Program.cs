using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string regex = @"^(.+)>(?<first>[0-9]{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<fourth>[^<>]{3})<\1$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, regex);

                if (match.Success)
                {
                    string password = match.Groups["first"].Value + match.Groups["second"].Value + match.Groups["third"].Value + match.Groups["fourth"].Value;
                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine($"Try another password!");
                }
            }
        }
    }
}