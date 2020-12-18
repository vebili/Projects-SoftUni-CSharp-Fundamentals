using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int nOfLines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < nOfLines; i++)
            {
                int poured = int.Parse(Console.ReadLine());
                if (sum + poured <= 255)
                {
                    sum += poured;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);
        }
    }
}
