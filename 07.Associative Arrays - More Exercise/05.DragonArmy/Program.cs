using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<double>>> dragons = new Dictionary<string, Dictionary<string, List<double>>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');

                string type = tokens[0];
                string name = tokens[1];

                double defaultDamage = 45;
                double defaultHealth = 250;
                double defaultArmor = 10;

                double newDamage;
                double newHealth;
                double newArmor;

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new Dictionary<string, List<double>>());
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type].Add(name, new List<double>());
                    dragons[type][name].Add(double.TryParse(tokens[2], out newDamage) ? newDamage : defaultDamage);
                    dragons[type][name].Add(double.TryParse(tokens[3], out newHealth) ? newHealth : defaultHealth);
                    dragons[type][name].Add(double.TryParse(tokens[4], out newArmor) ? newArmor : defaultArmor);
                }
                else
                {
                    dragons[type][name].Clear();
                    dragons[type][name].Add(double.TryParse(tokens[2], out newDamage) ? newDamage : defaultDamage);
                    dragons[type][name].Add(double.TryParse(tokens[3], out newHealth) ? newHealth : defaultHealth);
                    dragons[type][name].Add(double.TryParse(tokens[4], out newArmor) ? newArmor : defaultArmor);
                }
            }

            foreach (KeyValuePair<string, Dictionary<string, List<double>>> dragonType in dragons)
            {
                double avgDamage = 0d;
                double avgHealth = 0d;
                double avgArmor = 0d;
                double count = 0d;
                foreach (KeyValuePair<string, List<double>> stats in dragonType.Value)
                {
                    List<double> dragonStats = stats.Value;
                    avgDamage += dragonStats[0];
                    avgHealth += dragonStats[1];
                    avgArmor += dragonStats[2];
                    count++;
                }
                Console.WriteLine($"{dragonType.Key}::({avgDamage / count:f2}/{avgHealth / count:f2}/{avgArmor / count:f2})");

                foreach (var dragon in dragonType.Value.OrderBy(x => x.Key))
                {
                    List<double> dragonInfo = dragon.Value;

                    Console.WriteLine($"-{dragon.Key} -> damage: {dragonInfo[0]}, health: {dragonInfo[1]}, armor: {dragonInfo[2]}");
                }
            }
        }
    }
}