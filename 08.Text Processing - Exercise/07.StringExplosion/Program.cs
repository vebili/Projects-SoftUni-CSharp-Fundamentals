using System;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    continue;
                }
                if (power > 0)
                {
                    input = input.Remove(i, 1);
                    power--;
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}