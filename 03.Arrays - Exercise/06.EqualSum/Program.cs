using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;
            for (int i = 0; i < input.Length; i++)
            {
                int rightSum = 0;
                for (int j = i + 1; j < input.Length; j++)
                {
                    rightSum += input[j];
                }
                int leftSum = 0;
                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += input[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
