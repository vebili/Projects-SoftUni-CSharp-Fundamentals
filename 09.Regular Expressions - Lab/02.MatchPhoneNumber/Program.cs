using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359 2 [0-9]{3} [0-9]{4})|(\+359-2-[0-9]{3}-[0-9]{4})\b";
            string input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}