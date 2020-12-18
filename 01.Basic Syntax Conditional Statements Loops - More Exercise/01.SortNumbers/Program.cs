using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine(num1);
                if (num2 >= num3)
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                }
            }
            if (num2 >= num3 && num2 >= num1)
            {
                Console.WriteLine(num2);
                if (num1 > num3)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                }
            }
            if (num3 >= num2 && num3 >= num1)
            {
                Console.WriteLine(num3);
                if (num1 >= num2)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                }
            }
        }
    }
}
