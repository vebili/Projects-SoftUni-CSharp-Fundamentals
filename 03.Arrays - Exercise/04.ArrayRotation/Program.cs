using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            int rotate = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotate; i++)
            {
                string first = array[0];
                for (int j = 1; j < array.Length; j++)
                {
                    string current = array[j];
                    array[j - 1] = current;
                }
                array[array.Length - 1] = first;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
