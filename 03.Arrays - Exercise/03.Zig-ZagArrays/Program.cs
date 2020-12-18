using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] inputArray = Console.ReadLine().Split().ToArray();
                string elementZero = inputArray[0];
                string elementOne = inputArray[1];
                if (i % 2 != 0)
                {
                    arr2[i] = elementZero;
                    arr1[i] = elementOne;
                }
                else if (i % 2 == 0)
                {
                    arr1[i] = elementZero;
                    arr2[i] = elementOne;
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
