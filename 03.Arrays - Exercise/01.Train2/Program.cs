using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int capacityOfWagon = int.Parse(Console.ReadLine());
            string input;
            int morePeople = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] splitedInput = input.Split(" ");

                if (splitedInput.Length == 1)
                {
                    morePeople = int.Parse(splitedInput[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + morePeople <= capacityOfWagon)
                        {
                            wagons[i] += morePeople;
                            break;
                        }
                    }
                }
                else
                {
                    morePeople = int.Parse(splitedInput[1]);

                    wagons.Add(morePeople);
                }
            }
            string result = string.Join(" ", wagons);
            Console.WriteLine(result);
        }
    }
}