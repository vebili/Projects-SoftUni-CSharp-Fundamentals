using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                int nextChar = (int)input[i] + 3;
                Console.Write((char)nextChar);
            }
        }
    }
}