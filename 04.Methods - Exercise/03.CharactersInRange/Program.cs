using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            RangeOfChar(input1, input2);

        }
        static void RangeOfChar(char letter1, char letter2)
        {
            int start = Math.Min(letter1, letter2);
            int end = Math.Max(letter1, letter2);
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
