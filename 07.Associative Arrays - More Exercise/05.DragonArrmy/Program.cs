using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DragonArrmy
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, SortedDictionary<string, int[]>>();

            int n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0];
                string name = tokens[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                damage = tokens[2] == "null" ? 45 : int.Parse(tokens[2]);
                health = tokens[3] == "null" ? 250 : int.Parse(tokens[3]);
                armor = tokens[4] == "null" ? 10 : int.Parse(tokens[4]);

                if (!data.ContainsKey(type))
                {
                    data.Add(type, new SortedDictionary<string, int[]>());
                }

                if (!data[type].ContainsKey(name))
                {
                    data[type][name] = new int[3];
                }

                data[type][name][0] = damage;
                data[type][name][1] = health;
                data[type][name][2] = armor;
            }

            foreach (var outerKvp in data)
            {
                Console.WriteLine($"{outerKvp.Key}::({outerKvp.Value.Select(x => x.Value[0]).Average():F}/{outerKvp.Value.Select(x => x.Value[1]).Average():f}/{outerKvp.Value.Select(x => x.Value[2]).Average():f})");

                foreach (var innerKvp in outerKvp.Value)
                {
                    Console.WriteLine($"-{innerKvp.Key} -> damage: {innerKvp.Value[0]}, health: { innerKvp.Value[1]}, armor: {innerKvp.Value[2]}");
                }
            }
        }
    }
}