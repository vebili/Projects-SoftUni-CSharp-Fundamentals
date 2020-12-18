using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPriceWOTax = 0;
            string command = string.Empty;
            while (true)
            {
                command = Console.ReadLine();
                if (command == "special" || command == "regular")
                {
                    break;
                }
                double inputPrice = double.Parse(command);
                if (inputPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                totalPriceWOTax += inputPrice;
            }

            double taxes = totalPriceWOTax * 0.2;
            double totalPrice = totalPriceWOTax + taxes; ;
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (totalPrice > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWOTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                if (command == "regular")
                {
                    Console.WriteLine($"Total price: {totalPrice:f2}$");
                }
                else if (command == "special")
                {
                    Console.WriteLine($"Total price: {totalPrice * 0.9:f2}$");
                }
            }
        }
    }
}
