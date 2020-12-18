using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double fact1 = FactorialFunction(num1);
            double fact2 = FactorialFunction(num2);
            Console.WriteLine($"{fact1 / fact2:f2}");
        }
        static double FactorialFunction(int num)
        {
            double result = 1;
            while (num != 1)
            {
                result *= num;
                num -= 1;
            }
            return result;
        }
    }
}
