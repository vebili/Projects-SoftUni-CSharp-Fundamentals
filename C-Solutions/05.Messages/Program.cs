using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            string messages = string.Empty;

            for (int i = 0; i < nums; i++)
            {
                string digits = Console.ReadLine();
                int digitLength = digits.Length;
                int digit = digits[0] - '0';
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    messages += (char)(digit + 32);
                    continue;
                }

                if (digit == 8 || digit == 9)
                {
                    offset++;
                }

                int letterIndex = offset + digitLength - 1;
                messages += (char)(letterIndex + 97);
            }

            Console.WriteLine(messages);
        }
    }
}
