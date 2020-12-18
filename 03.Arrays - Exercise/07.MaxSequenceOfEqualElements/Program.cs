using System;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int bestCount = 0;
            int bestIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentNum = input[i];
                int counter = 1;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (currentNum == input[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestIndex = i;
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{input[bestIndex]} ");
            }
        }
    }
}
