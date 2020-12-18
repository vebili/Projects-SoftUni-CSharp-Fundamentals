using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> owned = Console.ReadLine()
                .Split(", ")
                .ToList();
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
                string[] cmdArgs = input.Split(", ");
                string command = cmdArgs[0];
                //int index = int.Parse(cmdArgs[1]);
            //string index = cmdArgs[1];
                //string card = cmdArgs[1];
            while (n > 0)
            {
                if (n > 6)
                {
                    int index = int.Parse(cmdArgs[1]);
                    //string card = cmdArgs[2];
                    if (Enumerable.Range(0, owned.Count - 0).Contains(index))
                    {
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                if (command == "Add")
                {
                    string card = cmdArgs[1];
                    //string card = cmdArgs[1];
                    if (owned.Contains(card))
                    {
                        Console.WriteLine("Card is already bought");
                    }
                    else
                    {
                        Console.WriteLine("Card successfully bought");
                    }
                }
                else if (command == "Remove")
                {
                    string card = cmdArgs[1];
                    if (owned.Contains(card))
                    {
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string card = cmdArgs[2];
                    if (!Enumerable.Range(0, owned.Count - 0).Contains(index))
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (!owned.Contains(card))
                    {
                        Console.WriteLine("Card successfully bought");
                    }
                    else
                    {
                        Console.WriteLine("Card is already bought");
                    }
                }
            n -= 1;
            }
            Console.WriteLine($"{string.Join(", ",owned)}");
        }
    }
}
