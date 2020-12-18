using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArr = command.Split().ToArray();
                switch (commandArr[0])
                {
                    case "Add":
                        num.Add(int.Parse(commandArr[1]));
                        break;

                    case "Insert":
                        if (int.Parse(commandArr[2]) <= num.Count && int.Parse(commandArr[2]) >= 0)
                        {
                            num.Insert(int.Parse(commandArr[2]), int.Parse(commandArr[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        if (int.Parse(commandArr[1]) <= num.Count && int.Parse(commandArr[1]) >= 0)
                        {
                            num.RemoveAt(int.Parse(commandArr[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        if (commandArr[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(commandArr[2]); i++)
                            {
                                int firstElement = num[0];
                                for (int j = 0; j < num.Count - 1; j++)
                                {
                                    num[j] = num[j + 1];
                                }
                                num[num.Count - 1] = firstElement;
                            }
                        }
                        else if (commandArr[1] == "right")
                        {
                            for (int i = 0; i < int.Parse(commandArr[2]); i++)
                            {
                                int lastElement = num[num.Count - 1];
                                for (int j = num.Count - 1; j > 0; j--)
                                {
                                    num[j] = num[j - 1];
                                }
                                num[0] = lastElement;
                            }
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
