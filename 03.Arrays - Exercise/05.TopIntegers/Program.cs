using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isBigger = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] >= currentElement)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write($"{currentElement} ");
                }
                isBigger = true;
            }
        }
    }
}
