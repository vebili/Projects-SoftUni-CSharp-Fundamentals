using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> totalCollection = new Dictionary<string, List<double>>();
            string command = Console.ReadLine();
            while (command != "buy")
            {
                string[] input = command.Split();
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                if (!totalCollection.ContainsKey(name))
                {
                    totalCollection.Add(name, new List<double> { price, quantity });
                }
                else
                {
                    totalCollection[name][0] = price;
                    totalCollection[name][1] += quantity;
                }
                command = Console.ReadLine();
            }
            foreach (var item in totalCollection)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}