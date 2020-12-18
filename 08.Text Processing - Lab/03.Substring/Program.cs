using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int index = str2.IndexOf(str1);
            while (index != -1)
            {
                str2 = str2.Remove(index, str1.Length);
                index = str2.IndexOf(str1);
            }
            Console.WriteLine(str2);
        }
    }
}