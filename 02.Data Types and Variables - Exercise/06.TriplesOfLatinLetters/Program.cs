using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            char first;
            char second;
            char third;
            for (int i = 0; i < count; i++)
            {
                first = (char)('a' + i);
                for (int j = 0; j < count; j++)
                {
                    second = (char)('a' + j);
                    for (int k = 0; k < count; k++)
                    {
                        third = (char)('a' + k);
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
