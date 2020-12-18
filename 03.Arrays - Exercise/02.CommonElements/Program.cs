using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();
            foreach (var item in arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (item == arr1[i])
                    {
                        Console.Write(item + " ");
                    }
                }
            }
        }
    }
}
