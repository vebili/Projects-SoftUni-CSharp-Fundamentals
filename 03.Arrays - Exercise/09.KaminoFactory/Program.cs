using System;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string input = null;
            int counter = 0;
            int bestCount = 0;
            int bestCounter = 0;
            int bestBeginIndex = 0;
            int bestSum = 0;
            string bestSequence = null;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string sequence = input.Replace("!", "");
                string[] dnaParts = sequence.Split("0", StringSplitOptions.RemoveEmptyEntries);
                int count = 0;
                int sum = 0;
                string bestSubSequence = null;
                counter++;
                foreach (string dnaPart in dnaParts)
                {
                    if (dnaPart.Length > count)
                    {
                        count = dnaParts.Length;
                        bestSubSequence = dnaPart;
                    }
                    sum += dnaPart.Length;
                }
                int beginIndex = sequence.IndexOf(bestSubSequence);
                if (count > bestCount || (count == bestCount && beginIndex < bestBeginIndex) || (count == bestCount && beginIndex == bestBeginIndex && sum > bestSum))
                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestBeginIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }
            }
            char[] result = bestSequence.ToCharArray();
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}