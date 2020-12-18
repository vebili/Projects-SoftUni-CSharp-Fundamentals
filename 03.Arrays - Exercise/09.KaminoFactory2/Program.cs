using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int length = int.Parse(Console.ReadLine());
            int[] lss = new int[length];
            int lssLength = int.MinValue, lssIndex = int.MinValue, lssSum = int.MinValue, lssStart = -1;
            int index = 1;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] data = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currLength = int.MinValue, currIndex = int.MinValue, currSubLength = 0, currSubIndex = 0;
                bool isOne = false;

                for (int i = 0; i < length; i++)
                {
                    if (data[i] == 1 && isOne)
                    {
                        currSubLength++;
                    }
                    else if (data[i] == 1)
                    {
                        isOne = true;
                        currSubIndex = i;
                        currSubLength = 1;
                    }
                    else if (data[i] == 0 && isOne)
                    {
                        if (currSubLength > currLength)
                        {
                            currLength = currSubLength;
                            currIndex = currSubIndex;
                        }
                        isOne = false;
                        currSubLength = 0;
                        currSubIndex = 0;
                    }
                }

                if (isOne)
                {
                    if (currSubLength > currLength)
                    {
                        currLength = currSubLength;
                        currIndex = currSubIndex;
                    }
                }

                if (currLength > lssLength)
                {
                    lssLength = currLength;
                    lssIndex = currIndex;
                    lssSum = data.Sum();
                    lss = data;
                    lssStart = index;
                }
                else if (currLength == lssLength)
                {
                    if (currIndex < lssIndex)
                    {
                        lssLength = currLength;
                        lssIndex = currIndex;
                        lssSum = data.Sum();
                        lss = data;
                        lssStart = index;
                    }
                    else if (currIndex == lssIndex)
                    {
                        if (data.Sum() > lssSum)
                        {
                            lssLength = currLength;
                            lssIndex = currIndex;
                            lssSum = data.Sum();
                            lss = data;
                            lssStart = index;
                        }
                    }
                }
                index++;
            }

            Console.WriteLine($"Best DNA sample {lssStart} with sum: {lssSum}.");
            Console.WriteLine(string.Join(" ", lss));
        }
    }
}
