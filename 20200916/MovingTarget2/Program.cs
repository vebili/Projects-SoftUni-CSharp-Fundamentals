using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input;

            while ((input = Console.ReadLine()?.ToUpper()) != "END")
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0]?.ToUpper();
                int index = int.Parse(tokens[1]);
                int value = int.Parse(tokens[2]);
                if (index < 0 || index >= targets.Count)
                {
                    if (command == "ADD")
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else if (command == "STRIKE")
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    continue;
                }
                switch (command)
                {
                    case "SHOOT":
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                        break;
                    case "ADD":
                        targets.Insert(index, value);
                        break;
                    case "STRIKE":
                        if (index - value < 0 || index + value >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }
                        targets.RemoveRange(index - value, (value * 2) + 1);

                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join('|', targets));
        }
    }
}
