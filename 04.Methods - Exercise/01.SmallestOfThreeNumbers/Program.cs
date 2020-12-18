using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            int int3 = int.Parse(Console.ReadLine());
            int result = SmallestNum(int1, int2, int3);
            Console.WriteLine(result);
        }
        static int SmallestNum(int num1, int num2, int num3)
        {
            if (num1 <= num2 && num1 <= num3)
            {
                return num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
