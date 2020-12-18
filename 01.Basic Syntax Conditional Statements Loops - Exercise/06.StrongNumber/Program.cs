using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = input;
            int currentNumber = 0;
            int factorialSum = 0;

            while (num != 0)
            {
                currentNumber = num % 10;
                num /= 10;
                int factorial = 1;
                for (int i = 1; i <= currentNumber; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }
            string answer = null;
            if (input == factorialSum)
            {
                answer = "yes";
            }
            else
            {
                answer = "no";
            }
            Console.WriteLine(answer);
        }
    }
}
