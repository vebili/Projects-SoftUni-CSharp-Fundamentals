using System;

namespace _01.CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalPrice = 0.00;
            string[] result = new string[n];
            for (int i = 0; i < n; i++)
            {
                double price = double.Parse(Console.ReadLine());                
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                price = ((days * capsules) * price);
                totalPrice += price;
                result[i] = ($"The price for the coffee is: ${price:f2}");
                price = 0.00;
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(result[j]);
                //Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
