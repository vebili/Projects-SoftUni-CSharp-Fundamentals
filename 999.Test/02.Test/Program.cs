using System;
using System.Text.RegularExpressions;

namespace _02.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"\|(?<name>[A-Z]{4,})\|:#(?<titel>[A-Za-z]+\s[A-Za-z]+)#";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                var matches = Regex.Match(input, pattern);
                int strenght = matches.Groups["name"].Value.Length;
                int armour = matches.Groups["titel"].Value.Length;
                if (matches.Success)
                {
                    Console.WriteLine($"{matches.Groups["name"].Value}, The {matches.Groups["titel"].Value}");
                    Console.WriteLine($">> Strength: {strenght}");
                    Console.WriteLine($">> Armour: {armour}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}