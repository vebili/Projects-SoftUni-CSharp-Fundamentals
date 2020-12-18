using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> theList = Console.ReadLine()
                                                .Split("|")
                                                .ToList();
            theList.Reverse();

            List<string> result = new List<string>();

            foreach (string item in theList)
            {
                string[] num = item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string numsToAdd in num)
                {
                    result.Add(numsToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}