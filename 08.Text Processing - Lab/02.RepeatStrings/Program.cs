using System;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string repeated = string.Empty;
            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    repeated += word;
                }
            }
            Console.WriteLine(repeated);
        }
    }
}