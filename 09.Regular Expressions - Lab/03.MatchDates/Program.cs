using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<date>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            foreach (Match item in matches)
            {
                Console.WriteLine($"Day: {item.Groups["date"].Value}, Month: {item.Groups["month"].Value}, Year: {item.Groups["year"].Value}");
            }
        }
    }
}