using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();
            List<int> second = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();
            while (first.Count != 0 && second.Count != 0)
            {
                int firstPlayCard = first[0];
                int secondPlayCard = second[0];
                if (firstPlayCard > secondPlayCard)
                {
                    first.Add(firstPlayCard);
                    first.Add(secondPlayCard);
                }
                else if (firstPlayCard < secondPlayCard)
                {
                    second.Add(secondPlayCard);
                    second.Add(firstPlayCard);
                }
                first.RemoveAt(0);
                second.RemoveAt(0);
            }
            if (first.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }
        }
    }
}