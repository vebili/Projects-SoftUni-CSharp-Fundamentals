using System;

namespace _01.Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] splitInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = splitInput[0];

                if (command == "Change")
                {
                    char oldChar = char.Parse(splitInput[1]);
                    char newChar = char.Parse(splitInput[2]);
                    text = text.Replace(oldChar, newChar);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string str = splitInput[1];

                    Console.WriteLine(text.Contains(str));
                }
                else if (command == "End")
                {
                    string str = splitInput[1];
                    Console.WriteLine(text.EndsWith(str));
                }
                else if (command == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char ch = char.Parse(splitInput[1]);
                    int index = text.IndexOf(ch);
                    Console.WriteLine(index);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(splitInput[1]);
                    int length = int.Parse(splitInput[2]);
                    string subString = text.Substring(startIndex, length);
                    Console.WriteLine(subString);
                }
                input = Console.ReadLine();
            }
        }
    }
}
