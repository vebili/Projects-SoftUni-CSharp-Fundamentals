using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> specialNum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int bomb = specialNum[0];
            int power = specialNum[1];
            for (int i = 0; i < num.Count; i++)
            {
                int currentNum = num[i];
                if (currentNum == bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > num.Count - 1)
                    {
                        endIndex = num.Count - 1;
                    }
                    int endIndexToRemove = endIndex - startIndex + 1;
                    num.RemoveRange(startIndex, endIndexToRemove);
                    i = startIndex - 1;
                }
            }
            Console.WriteLine(num.Sum());
        }
    }
}