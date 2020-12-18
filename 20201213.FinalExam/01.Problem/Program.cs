using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //string command = Console.ReadLine();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Done")
            {
                //string[] command = command.Split();

                if (command[0] == "Change")
                {
                    text = text.Replace(command[1], command[2]);
                    Console.WriteLine(text);
                }
                else if (command[0] == "Includes")
                {
                    if (text.Contains(command[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command[0] == "End")
                {
                    int element = text.IndexOf(command[1]);
                    int lastIndex = text.Length - 1;

                    if (element == lastIndex)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command[0] == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command[0] == "FindIndex")
                {
                    int index = text.IndexOf(command[1]);
                    Console.WriteLine(index);
                }
                else if (command[0] == "Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    text = text.Substring(startIndex, length);
                    Console.WriteLine(text);
                }

                command = Console.ReadLine().Split(); ;
            }
        }
    }
}