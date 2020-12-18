using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            chars(input);
        }
        static void chars(string text)
        {
            int length = text.Length;
            int middleChar = length / 2;
            if (length % 2 == 0)
            {
                Console.Write(text[middleChar - 1]);
                Console.Write(text[middleChar]);
            }
            else
            {
                Console.WriteLine(text[middleChar]);
            }
        }
    }
}
