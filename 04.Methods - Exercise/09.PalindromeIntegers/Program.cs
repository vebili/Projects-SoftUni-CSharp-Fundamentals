using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            string current = string.Empty;
            while (true)
            {
                command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                for (int i = command.Length; i > 0; i--)
                {
                    current += command[i - 1];
                }
                if (current == command)
                {
                    Console.WriteLine("true");
                    current = string.Empty;
                }
                else
                {
                    Console.WriteLine("false");
                    current = string.Empty;
                }
            }
        }
    }
}
