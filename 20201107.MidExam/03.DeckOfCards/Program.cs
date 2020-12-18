using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.DeckOfCards1
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
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = input.Split(", ");
                string command = cmdArgs[0];
                //string cardName = cmdArgs[1];
                //int index = int.Parse(cmdArgs[1]);
                //string insertCardName = cmdArgs[2];
                if (command == "Add")
                {
                    string cardNameAdd = cmdArgs[1];
                    if (!owned.Contains(cardNameAdd))
                    {
                        Console.WriteLine("Card successfully bought");
                        owned.Add(cardNameAdd);
                    }
                    else
                    {
                        Console.WriteLine("Card is already bought");
                    }
                }
                else if (command == "Remove")
                {
                    string cardNameRemove = cmdArgs[1];
                    if (owned.Contains(cardNameRemove))
                    {
                        Console.WriteLine("Card successfully sold");
                        owned.Remove(cardNameRemove);
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(cmdArgs[1]);
                    //string insertCardName = cmdArgs[2];

                    if (index < 0 || index > owned.Count)
                    {
                        Console.WriteLine("Index out of range");                       
                    }
                    else
                    {
                        owned.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string cardNameInsert = cmdArgs[2];

                    if (index < 0 || index > owned.Count)
                    {
                        Console.WriteLine("Index out of range");                        
                    }
                    else
                    {
                        if (!owned.Contains(cardNameInsert))
                        {
                            Console.WriteLine("Card is already bought");
                        }
                        else
                        {
                            owned.Insert(index, cardNameInsert);
                            Console.WriteLine("Card successfully bought");
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(", ", owned));
        }
    }
}
