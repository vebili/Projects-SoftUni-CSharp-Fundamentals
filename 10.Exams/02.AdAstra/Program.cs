using System;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\#|\|)(?<item>[A-Za-z\s]+)\1(?<date>(\d{2})\/(\d{2})\/(\d{2}))\1(?<calories>\d+)\1";
            string input = Console.ReadLine();
            Regex regEx = new Regex(pattern);
            MatchCollection collection = regEx.Matches(input);
            int totalCalories = 0;
            foreach (Match item in collection)
            {
                totalCalories += int.Parse(item.Groups["calories"].Value);
            }
            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");
            foreach (Match item in collection)
            {
                Console.WriteLine($"Item: {item.Groups["item"].Value}, Best before: {item.Groups["date"].Value}, Nutrition: {int.Parse(item.Groups["calories"].Value)}");
            }
        }
    }
}