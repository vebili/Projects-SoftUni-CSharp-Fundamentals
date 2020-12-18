using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }

                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
