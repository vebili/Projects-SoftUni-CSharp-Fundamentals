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
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();
            string commandLine = "";

            while ((commandLine = Console.ReadLine()) != "Eat")
            {
                string command = commandLine.Split(" ")[0];
                string biscuit = commandLine.Split(" ")[1];

                if (command == "Update-Any")
                {                    
                    if (list.Contains(biscuit))
                    {
                        int index = list.IndexOf(biscuit);
                        list.Remove(biscuit);
                        list.Insert(index, "Out of stock");
                    }

                }
                else if (command == "Remove")
                {
                    int index = int.Parse(commandLine.Split(" ")[2]);
                    if (list.Count > index && index >= 0)
                    {
                        list.RemoveAt(index);
                        list.Insert(index, biscuit);
                    }

                }
                else if (command == "Update-Last")
                {
                    list.RemoveAt(list.Count - 1);
                    list.Add(biscuit);
                }
                else if (command == "Rearrange")
                {
                    if (list.Contains(biscuit))
                    {
                        list.Remove(biscuit);
                        list.Add(biscuit);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list.Where(x => x != "Out of stock")));
        }
    }
}