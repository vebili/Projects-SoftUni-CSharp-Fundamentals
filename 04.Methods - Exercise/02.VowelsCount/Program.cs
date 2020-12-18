using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int result = VowelsCount(input);
            Console.WriteLine(result);
        }
        static int VowelsCount(string text)
        {
            char[] vowelsArr = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            foreach (char item in vowelsArr)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (item == text[i])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
