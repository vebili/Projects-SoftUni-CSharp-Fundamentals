using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string longNumber = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());
            int temp = 0;
            if (num == 0 || longNumber == "")
            {
                Console.WriteLine(0);
                return;
            }
            foreach (var ch in longNumber.Reverse())
            {
                int digit = int.Parse(ch.ToString());
                int result = digit * num + temp;
                int restDigit = result % 10;
                temp = result / 10;
                sb.Insert(0, restDigit);
            }
            if (temp > 0)
            {
                sb.Insert(0, temp);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}