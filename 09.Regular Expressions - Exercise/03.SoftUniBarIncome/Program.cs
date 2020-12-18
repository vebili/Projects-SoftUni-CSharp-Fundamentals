using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)\$";
            double totalIncome = 0;
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    double totalPrice = int.Parse(match.Groups["quantity"].Value) * double.Parse(match.Groups["price"].Value);
                    totalIncome += totalPrice;
                    Console.WriteLine($"{match.Groups["name"].Value}: {match.Groups["product"].Value} - {totalPrice:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}