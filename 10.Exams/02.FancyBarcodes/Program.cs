using System;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@[\#]+([A-Z][A-Za-z0-9]{4,}[A-Z])\@[\#]+";
            Regex regEx = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Match match = regEx.Match(barcode);
                if (match.Success)
                {
                    string productGroup = "";
                    for (int j = 0; j < match.Value.Length; j++)
                    {
                        if (char.IsDigit(match.Value[j]))
                        {
                            productGroup += match.Value[j];
                        }
                    }
                    if (productGroup == "")
                    {
                        productGroup = "00";
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                    productGroup = "";
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}