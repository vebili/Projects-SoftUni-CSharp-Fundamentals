using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                List<string> commandList = command.Split().ToList();
                if (commandList[0] == "Add")
                {
                    wagons.Add(int.Parse(commandList[1]));
                }
                else
                {
                    int passengers = int.Parse(commandList[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];
                        bool isFull = currentWagon + passengers <= capacity;
                        if (isFull)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
