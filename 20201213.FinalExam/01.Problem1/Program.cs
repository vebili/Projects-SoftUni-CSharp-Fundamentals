using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {            
            string text = Console.ReadLine();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Done")
            {
                if (command[0] == "Change")
                {
                    text = text.Replace(command[1], command[2]);
                    Console.WriteLine(text);
                }
                if (command[0] == "Includes")
                {
                    bool includes = text.Contains(command[1]);
                    Console.WriteLine(includes);
                }
                if (command[0] == "End")
                {
                    bool end = text.EndsWith(command[1]);
                    Console.WriteLine(end);
                }
                if (command[0] == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                if (command[0] == "FindIndex")
                {
                    int index = text.IndexOf(command[1]);
                    Console.WriteLine(index);
                }
                if (command[0] == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int lenght = int.Parse(command[2]);

                    text = text.Substring(index, lenght);
                    Console.WriteLine(text);
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}