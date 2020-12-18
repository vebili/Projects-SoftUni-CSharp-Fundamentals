using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> heroAndHP = new Dictionary<string, int>();
            Dictionary<string, int> heroAndMP = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);
                heroAndHP.Add(heroName, hp);
                heroAndMP.Add(heroName, mp);
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] arguments = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                string name = arguments[1];
                int amount = 0;
                switch (action)
                {
                    case "CastSpell":
                        int neededMP = int.Parse(arguments[2]);
                        string spellName = arguments[3];
                        if (neededMP <= heroAndMP[name])
                        {
                            heroAndMP[name] -= neededMP;
                            Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroAndMP[name]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(arguments[2]);
                        string attacker = arguments[3];
                        heroAndHP[name] -= damage;
                        if (heroAndHP[name] > 0)
                        {
                            Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroAndHP[name]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} has been killed by {attacker}!");
                            heroAndHP.Remove(name);
                            heroAndMP.Remove(name);
                        }
                        break;
                    case "Recharge":
                        amount = int.Parse(arguments[2]);
                        heroAndMP[name] += amount;
                        if (heroAndMP[name] > 200)
                        {
                            Console.WriteLine($"{name} recharged for {200 - (heroAndMP[name] - amount)} MP!");
                            heroAndMP[name] = 200;
                        }
                        else
                        {
                            Console.WriteLine($"{name} recharged for {amount} MP!");
                        }
                        break;
                    case "Heal":
                        amount = int.Parse(arguments[2]);
                        heroAndHP[name] += amount;
                        if (heroAndHP[name] > 100)
                        {
                            Console.WriteLine($"{name} healed for {100 - (heroAndHP[name] - amount)} HP!");
                            heroAndHP[name] = 100;

                        }
                        else
                        {
                            Console.WriteLine($"{name} healed for {amount} HP!");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var item in heroAndHP.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"HP: {item.Value}");
                Console.WriteLine($"MP: {heroAndMP[item.Key]}");
            }
        }
    }
}