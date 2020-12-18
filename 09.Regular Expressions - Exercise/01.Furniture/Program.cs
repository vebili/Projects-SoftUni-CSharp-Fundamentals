using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<furniture>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            double total = 0.0;
            List<string> furnitureList = new List<string>();
            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    string name = (match.Groups["furniture"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    total += price * quantity;
                    furnitureList.Add(name);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (furnitureList.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, furnitureList)}");
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}