using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int battles = 0;
            int wins = 0;
            bool isWinner = true;

            string input = Console.ReadLine();

            while (input?.ToUpper() != "END OF BATTLE")
            {
                battles++;
                int distance = int.Parse(input);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    isWinner = false;
                    break;
                }
                wins++;
                energy -= distance;

                if (battles % 3 == 0)
                {
                    energy += wins;
                }

                input = Console.ReadLine();
            }
            if (isWinner)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
