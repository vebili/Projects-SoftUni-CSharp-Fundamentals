using System;

namespace CounterStrike2
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int battlesWon = 0;
            string cmd = Console.ReadLine();
            string output = string.Empty;
            while (cmd != "End of battle")
            {
                int distance = int.Parse(cmd);
                if (energy - distance >= 0)
                {
                    energy -= distance;
                    battlesWon++;
                }
                else
                {
                    output = $"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy";
                    break;
                }
                if (battlesWon % 3 == 0)
                {
                    energy += battlesWon;
                }
                cmd = Console.ReadLine();
                if (cmd == "End of battle")
                {
                    output = $"Won battles: {battlesWon}. Energy left: {energy}";
                }
            }
            Console.WriteLine(output);
        }
    }
}
