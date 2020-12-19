using System;
using System.Text.RegularExpressions;

namespace _02.Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\$|%)([A-Z][a-z]{2,})(\1): \[([0-9]+)\]\|\[([0-9]+)\]\|\[([0-9]+)\]\|$";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    int first = int.Parse(match.Groups[4].Value);
                    int second = int.Parse(match.Groups[5].Value);
                    int third = int.Parse(match.Groups[6].Value);
                    char firstChar = (char)first;
                    char secondChar = (char)second;
                    char thirdChar = (char)third;
                    string message = firstChar.ToString() + secondChar.ToString() + thirdChar.ToString();
                    Console.WriteLine($"{match.Groups[2].Value}: {message}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
