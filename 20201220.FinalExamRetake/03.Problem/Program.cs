using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> spellBook = new Dictionary<string, List<string>>();
            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Enroll":
                        spellBook = EnrollHeroes(spellBook, cmdArgs);
                        break;
                    case "Learn":
                        spellBook = LearnHeroes(spellBook, cmdArgs);
                        break;

                    case "Unlearn":
                        UnlearnHeroes(spellBook, cmdArgs);
                        break;
                }
            }
            spellBook = spellBook.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Heroes:");
            foreach (var kvp in spellBook)
            {
                string spells = string.Join(", ", kvp.Value);
                Console.WriteLine($"== {kvp.Key}: {spells}");
            }
        }
        private static void UnlearnHeroes(Dictionary<string, List<string>> spellBook, string[] cmdArgs)
        {
            string heroName = cmdArgs[1];
            string spellNeme = cmdArgs[2];
            if (spellBook.ContainsKey(heroName))
            {
                if (spellBook[heroName].Contains(spellNeme))
                {
                    spellBook[heroName].Remove(spellNeme);
                }
                else
                {
                    Console.WriteLine($"{heroName} doesn't know {spellNeme}.");
                }
            }
            else
            {
                Console.WriteLine($"{heroName} doesn't exist.");
            }
        }
        private static Dictionary<string, List<string>> LearnHeroes(Dictionary<string, List<string>> spellBook, string[] cmdArgs)
        {
            string heroName = cmdArgs[1];
            string spellName = cmdArgs[2];
            if (spellBook.ContainsKey(heroName))
            {
                if (spellBook[heroName].Contains(spellName))
                {
                    Console.WriteLine($"{heroName} has already learnt {spellName}.");
                }
                else
                {
                    spellBook[heroName].Add(spellName);
                }
            }
            else
            {
                Console.WriteLine($"{heroName} doesn't exist.");
            }
            return spellBook;
        }
        private static Dictionary<string, List<string>> EnrollHeroes(Dictionary<string, List<string>> spellBook, string[] cmdArgs)
        {
            string heroName = cmdArgs[1];
            if (spellBook.ContainsKey(heroName))
            {
                Console.WriteLine($"{heroName} is already enrolled.");
            }
            else
            {
                spellBook.Add(heroName, new List<string>());
            }
            return spellBook;
        }
    }
}