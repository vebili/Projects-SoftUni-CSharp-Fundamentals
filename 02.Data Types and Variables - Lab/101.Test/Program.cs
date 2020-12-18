using System;

namespace _101.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split();
            int[] arr = new int[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }
            Console.WriteLine(string.Join("|", arr));
        }
    }
}
