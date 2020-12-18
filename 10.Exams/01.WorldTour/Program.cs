using System;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] arguments = command.Split(":");
                string action = arguments[0];
                switch (action)
                {
                    case "Add Stop":
                        int index = int.Parse(arguments[1]);
                        string stop = arguments[2];
                        if (index >= 0 && index < input.Length)
                        {
                            input = input.Insert(index, stop);
                        }
                        Console.WriteLine(input);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        if (startIndex >= 0 && startIndex < input.Length && endIndex >= 0 && endIndex < input.Length)
                        {
                            input = input.Remove(startIndex, endIndex - startIndex + 1);
                        }
                        Console.WriteLine(input);
                        break;
                    case "Switch":
                        string oldString = arguments[1];
                        string newString = arguments[2];
                        if (input.Contains(oldString))
                        {
                            input = input.Replace(oldString, newString);
                        }
                        Console.WriteLine(input);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}