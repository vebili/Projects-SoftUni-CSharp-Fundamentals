using System;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            string randomStr = Console.ReadLine();
            int sum = 0;

            foreach (char symbol in randomStr)
            {
                if (symbol > start && symbol < end)
                {
                    sum += symbol;
                }
            }
            Console.WriteLine(sum);
        }
    }
}