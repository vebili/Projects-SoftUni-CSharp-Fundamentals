using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double spend = 0;

            while (true)
            {
                string game = Console.ReadLine();
                if (game == "Game Time")
                {
                    break;
                }

                double gamePrice = 0;
                switch (game)
                {
                    case "OutFall 4": 
                        gamePrice = 39.99; 
                        break;
                    case "CS: OG": 
                        gamePrice = 15.99; 
                        break;
                    case "Zplinter Zell": 
                        gamePrice = 19.99; 
                        break;
                    case "Honored 2": 
                        gamePrice = 59.99; 
                        break;
                    case "RoverWatch": 
                        gamePrice = 29.99; 
                        break;
                    case "RoverWatch Origins Edition": 
                        gamePrice = 39.99; 
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (gamePrice > money)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                money -= gamePrice;
                spend += gamePrice;
                Console.WriteLine($"Bought {game}");

                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${money:f2}");
        }
    }
}
