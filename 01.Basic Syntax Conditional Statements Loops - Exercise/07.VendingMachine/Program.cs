using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            string input = Console.ReadLine();
            while (input != "Start")
            {
                decimal coin = decimal.Parse(input);
                if (coin == 0.1m || coin == 0.2m || coin == 0.5m || coin == 1m || coin == 2m)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                input = Console.ReadLine();
            }

            string order = Console.ReadLine();
            while (order != "End")
            {
                switch (order)
                {
                    case "Coke":
                        if (sum >= 1m)
                        {
                            Console.WriteLine("Purchased coke");
                            sum -= 1m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":

                        if (sum >= 0.8m)
                        {
                            Console.WriteLine("Purchased soda");
                            sum -= 0.8m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Crisps":
                        if (sum >= 1.5m)
                        {
                            Console.WriteLine("Purchased crisps");
                            sum -= 1.5m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (sum >= 0.7m)
                        {
                            Console.WriteLine("Purchased water");
                            sum -= .7m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Nuts":
                        if (sum >= 2m)
                        {
                            Console.WriteLine("Purchased nuts");
                            sum -= 2m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                order = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
