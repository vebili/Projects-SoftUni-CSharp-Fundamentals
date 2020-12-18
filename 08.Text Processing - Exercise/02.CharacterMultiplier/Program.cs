using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        public static int Multiply(string string1, string string2)
        {
            int str1Length = string1.Length;
            int str2Lenght = string2.Length;
            int result = 0;
            if (str1Length == str2Lenght)
            {
                for (int i = 0; i < str1Length; i++)
                {
                    result += (int)string1[i] * (int)string2[i];
                }
            }
            else
            {
                if (str1Length > str2Lenght)
                {
                    for (int i = 0; i < str2Lenght; i++)
                    {
                        result += (int)string2[i] * (int)string1[i];
                    }
                    string sub = string1.Substring(str2Lenght);
                    for (int j = 0; j < sub.Length; j++)
                    {
                        result += (int)sub[j];
                    }
                }
                else if (str2Lenght > str1Length)
                {
                    for (int i = 0; i < str1Length; i++)
                    {
                        result += (int)string1[i] * (int)string2[i];
                    }
                    string sub2 = string2.Substring(str1Length);
                    for (int j = 0; j < sub2.Length; j++)
                    {
                        result += (int)sub2[j];
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string str1 = input[0];
            string str2 = input[1];
            Console.WriteLine(Multiply(str1, str2));
        }
    }
}