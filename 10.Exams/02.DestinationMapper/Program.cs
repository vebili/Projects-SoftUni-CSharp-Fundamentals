using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string text = Console.ReadLine();
            string pattern = @"(/|=)([A-Z][A-z]{2,})\1";
            Regex regex = new Regex(pattern);

            MatchCollection machCol = Regex.Matches(text, pattern);

            int result = 0;
            for (int i = 0; i < machCol.Count; i++)
            {
                words.Add(machCol[i].Groups[2].Value);
                result += machCol[i].Groups[2].Value.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", words)}");
            Console.WriteLine($"Travel Points: {result}");
        }
    }
}