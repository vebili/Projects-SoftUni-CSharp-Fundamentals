using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            int sum = SumInts(input1, input2);
            Console.WriteLine(Subtract(sum, input3));
        }
        static int SumInts(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        static int Subtract(int sum, int num3)
        {
            int subt = sum - num3;
            return subt;
        }
    }
}
