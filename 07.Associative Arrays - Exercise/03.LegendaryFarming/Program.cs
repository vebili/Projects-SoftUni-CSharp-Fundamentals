using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterial = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterial = new Dictionary<string, int>();
            keyMaterial["shards"] = 0;
            keyMaterial["fragments"] = 0;
            keyMaterial["motes"] = 0;
            bool hasBreak = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterial[material] += quantity;
                        if (keyMaterial[material] >= 250)
                        {
                            keyMaterial[material] -= 250;
                            if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            hasBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterial.ContainsKey(material))
                        {
                            junkMaterial.Add(material, 0);
                        }
                        junkMaterial[material] += quantity;
                    }
                }
                if (hasBreak)
                {
                    break;
                }
            }
            Dictionary<string, int> filteredKeyMaterial = keyMaterial
                .OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key)
                .ToDictionary(a => a.Key, a => a.Value);
            foreach (var item in filteredKeyMaterial)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterial.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}