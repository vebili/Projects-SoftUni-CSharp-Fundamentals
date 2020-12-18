using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int inputSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = input[i];
                for (int j = i + 1; j < input.Length; j++)
                {
                    int currentNum2 = input[j];
                    if (inputSum == currentNum + currentNum2)
                    {
                        Console.WriteLine($"{currentNum} {currentNum2}");
                    }
                }
            }
        }
    }
}
