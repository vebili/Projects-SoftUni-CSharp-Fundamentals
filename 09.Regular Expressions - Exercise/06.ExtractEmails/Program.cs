using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            var match = regex.Matches(input);
            foreach (Match item in match)
            {
                Console.WriteLine(item);
            }
        }
    }
}