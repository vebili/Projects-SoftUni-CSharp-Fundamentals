using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ListManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friend = Console.ReadLine()
                .Split(", ")
                .ToList();
            string input = Console.ReadLine();
            int blacklist = 0;
            int lost = 0;
            while (input != "Report")
            {
                string[] command = input.Split(" ")
                    .ToArray();
                string operation = command[0];
                if (operation == "Blacklist")
                {
                    if (friend.Contains(command[1]))
                    {
                        int index = friend.IndexOf(command[1]);
                        friend.RemoveAt(index);
                        friend.Insert(index, "Blacklisted");
                        Console.WriteLine($"{command[1]} was blacklisted.");
                        blacklist++;
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} was not found.");
                    }
                }
                else if (operation == "Error")
                {
                    int index = int.Parse(command[1]);

                    if (index < friend.Count && index >= 0)
                    {
                        if (friend[index] != "Blacklisted" && friend[index] != "Lost")

                        {
                            string name = friend[index];
                            friend.RemoveAt(index);
                            friend.Insert(index, "Lost");
                            //Console.WriteLine(list[index]);
                            Console.WriteLine($"{name} was lost due to an error.");
                            lost++;
                        }
                    }
                }
                else if (operation == "Change")
                {
                    int index = int.Parse(command[1]);
                    string newName = command[2];
                    if (index < friend.Count && index >= 0)
                    {
                        string currentName = friend[index];
                        friend.RemoveAt(index);
                        friend.Insert(index, newName);
                        Console.WriteLine($"{currentName} changed his username to {newName}. ");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Blacklisted names: {blacklist} ");
            Console.WriteLine($"Lost names: {lost} ");
            Console.WriteLine(string.Join(" ", friend));
        }
    }
}
