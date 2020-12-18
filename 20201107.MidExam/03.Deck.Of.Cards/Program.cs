using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Deck.Of.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<string> owned = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string[] cmdArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                    string command = cmdArgs[0];
                    if (command == "Add")
                    {
                        string cardName = cmdArgs[1];
                        if (owned.Contains(cardName))
                        {
                            Console.WriteLine($"Card is already bought");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Card successfully bought");
                            owned.Add(cardName);
                            continue;
                        }
                    }
                    else if (command == "Remove")
                    {
                        string cardName = cmdArgs[1];
                        if (owned.Contains(cardName))
                        {
                            Console.WriteLine($"Card successfully sold");
                            owned.Remove(cardName);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Card not found");
                            continue;

                        }
                    }
                    else if (command == "Remove At")
                    {
                        int index = int.Parse(cmdArgs[1]);
                        if (index < 0 || index > owned.Count - 1)
                        {
                            Console.WriteLine("Index out of range");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Card successfully sold");
                            owned.RemoveAt(index);
                            continue;
                        }
                    }
                    else if (command == "Insert")
                    {
                        int index = int.Parse(cmdArgs[1]);
                        string cardName = cmdArgs[2];
                        if (index >= 0 && index <= owned.Count - 1)
                        {
                            if (owned.Contains(cardName))
                            {
                                Console.WriteLine("Card is already bought");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Card successfully bought");
                                owned.Insert(index, cardName);
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                            continue;
                        }
                    }
                }
                Console.WriteLine(string.Join(", ", owned));
            }
        }
    }
}