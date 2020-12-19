using System;
using System.Collections.Generic;

namespace _01.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> collection = new SortedDictionary<string, string>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmd = command.Split();
                string currcmd = cmd[0];
                string heroName = cmd[1];

                if (currcmd == "Enroll")
                {
                    if (!collection.ContainsKey(heroName))
                    {
                        collection.Add(heroName, "");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                if (currcmd == "Learn")
                {
                    string spell = cmd[2];
                    if (!collection.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else
                    {
                        if (collection.ContainsValue(spell))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spell}.");
                        }
                        else
                        {
                            collection[heroName] = spell;
                        }
                    }
                }
                if (currcmd == "Unlearn")
                {
                    string spell = cmd[2];

                    if (!collection.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else
                    {
                        if (!collection.ContainsValue(spell))
                        {
                            Console.WriteLine($"{heroName} doesn't know {spell}.");
                        }
                        else
                        {
                            collection.Remove(spell);

                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Heroes:");
            foreach (var item in collection)
            {
                Console.WriteLine($"== {item.Key}: {item.Value}");
            }
        }
    }
}