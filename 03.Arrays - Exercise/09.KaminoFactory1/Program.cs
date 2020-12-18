using System;
using System.Linq;

namespace _09.KaminoFactory1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] bestDna = null;
            int bestLen = -1;
            int startIndex = -1;
            int bestDnaSum = 0;
            int bestSampleIndex = 0;

            int currSampleIndex = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                string[] currDna = input.Split('!', StringSplitOptions.RemoveEmptyEntries);
                int currLen = 0;
                int currBestLen = 0;
                int currEndIndex = 0;

                for (int a = 0; a < currDna.Length; a++)
                {
                    if (currDna[a] == "1")
                    {
                        currLen++;
                        if (currLen > currBestLen)
                        {
                            currEndIndex = a;
                            currBestLen = currLen;
                        }
                    }
                    else
                    {
                        currLen = 0;
                    }
                }

                int currStartIndex = currEndIndex - currBestLen + 1;

                bool isCurrDnaBetter = false;
                int currDnaSum = currDna.Select(int.Parse).Sum();

                if (currBestLen > bestLen)
                {
                    isCurrDnaBetter = true;
                }
                else if (currBestLen == bestLen)
                {
                    if (currStartIndex < startIndex)
                    {
                        isCurrDnaBetter = true;
                    }
                    else if (currStartIndex == startIndex)
                    {
                        if (currDnaSum > bestDnaSum)
                        {
                            isCurrDnaBetter = true;
                        }
                    }
                }

                currSampleIndex++;

                if (isCurrDnaBetter)
                {
                    bestDna = currDna;
                    bestLen = currBestLen;
                    startIndex = currStartIndex;
                    bestDnaSum = currDnaSum;
                    bestSampleIndex = currSampleIndex;
                }
            }

            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(' ', bestDna));
        }
    }
}
