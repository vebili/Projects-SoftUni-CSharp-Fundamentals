using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var barcodePattern = @"(@#+)[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            var barcodesCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < barcodesCount; i++)
            {
                var currentBarcode = Console.ReadLine();
                var match = Regex.Match(currentBarcode, barcodePattern);

                if (match.Success)
                {
                    var barcodeInfo = match.Value;
                    var productGroup = "";
                    productGroup = barcodeInfo
                        .Where(e => char.IsDigit(e))
                        .Aggregate(productGroup, (t, e) => t + e);

                    if (string.IsNullOrEmpty(productGroup))
                    {
                        productGroup = "00";
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}