using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (dict.ContainsKey(letter))
                    {
                        dict[letter] += 1;
                    }
                    else
                    {
                        dict.Add(letter, 1);
                    }
                }
            }
            foreach (var letter in dict)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
