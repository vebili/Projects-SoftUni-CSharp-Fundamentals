using System;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(", ")
                /*.Where(s => !string.IsNullOrWhiteSpace(s))*/
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Eat")
            {
                string command = input.Split(" ")[0];
                string name = input.Split(" ")[1];

                if (command == "Update-Any")
                {
                    string oldName = input.Split(" ")[1];
                    string newName = "Out of stock";

                    if (!list.Contains(name))
                    {
                        list.Remove(oldName);
                        list.Add(newName);
                    }
                }
                else if (command == "Remove")
                {
                    string oldName = input.Split(" ")[1];
                    string newName = input.Split(" ")[2];

                    if (list.Contains(oldName) && !list.Contains(newName))
                    {
                        int index = list.IndexOf(oldName);
                        list.Remove(oldName);
                        list.Insert(index, newName);
                    }
                }
                else if (command == "Update-Last")
                {
                    if (list.Contains(name))
                    {
                        list.Remove(name);
                    }
                }
                else if (command == "Rearrange")
                {
                    if (list.Contains(name))
                    {
                        list.Remove(name);
                        list.Add(name);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
