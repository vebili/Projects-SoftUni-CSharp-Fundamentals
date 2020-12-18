using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                char firstLet = current[0];
                char lastLet = current[current.Length - 1];
                double number = double.Parse(current.Substring(1, current.Length - 2));
                int firstLetIndex = alphabet.IndexOf(char.ToUpper(firstLet));
                int lastLetIndex = alphabet.IndexOf(char.ToUpper(lastLet));

                if ((int)firstLet >= 65 && (int)firstLet <= 90)
                {
                    number /= (firstLetIndex + 1);
                }
                else
                {
                    number *= (firstLetIndex + 1);
                }
                if ((int)lastLet >= 65 && (int)lastLet <= 90)
                {
                    number -= (lastLetIndex + 1);
                }
                else
                {
                    number += (lastLetIndex + 1);
                }
                result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}