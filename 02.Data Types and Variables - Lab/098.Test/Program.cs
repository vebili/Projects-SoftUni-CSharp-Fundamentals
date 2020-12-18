using System;

namespace _098.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10, 20, 30, 40, 50};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
                Console.WriteLine(string.Join(" | ", arr));
        }
    }
}
