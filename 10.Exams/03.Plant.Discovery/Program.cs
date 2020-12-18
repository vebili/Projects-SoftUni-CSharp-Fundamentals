using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Plant.Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plantNameAverageRating = new Dictionary<string, List<double>>();
            Dictionary<string, int> plantNameRarity = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = tokens[0];
                int rarity = int.Parse(tokens[1]);

                plantNameRarity.Add(plantName, rarity);
                plantNameAverageRating.Add(plantName, new List<double>());
            }
            string cmdArg = Console.ReadLine();
            while ("Exhibition" != cmdArg)
            {
                string[] tokens = cmdArg
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string[] comand = tokens[0].Split(":");
                string comandIf = comand[0];
                string plant = comand[1].Trim();

                if (comandIf == "Rate")
                {
                    int rating = int.Parse(tokens[1]);
                    var maches = plantNameAverageRating.Where(x => x.Key == plant).ToList();
                    if (maches.Count <= 0)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        if (plantNameAverageRating.ContainsKey(plant) == false)
                        {
                            plantNameAverageRating.Add(plant, new List<double>());
                        }
                        plantNameAverageRating[plant].Add(rating);
                    }
                }
                else if (comandIf == "Update")
                {
                    var maches = plantNameAverageRating.Where(x => x.Key == plant).ToList();
                    if (maches.Count <= 0)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        int rarity = int.Parse(tokens[1]);
                        plantNameRarity[plant] = rarity;
                    }

                }
                else if (comandIf == "Reset")
                {
                    var maches = plantNameAverageRating.Where(x => x.Key == plant).ToList();
                    if (maches.Count <= 0)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        plantNameAverageRating[plant] = new List<double>();
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
                cmdArg = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plantNameAverageRating)
            {
                if (item.Value.Count > 0)
                {
                    double avg = item.Value.Average();
                    //item.Value.RemoveAll(c => c == c);
                    item.Value.Add(avg);

                }
                else
                {
                    item.Value.Add(0);
                }
            }
            plantNameRarity.OrderByDescending(x => x.Value);
            plantNameAverageRating.OrderByDescending(x => x.Value);

            foreach (var itemm in plantNameRarity.OrderByDescending(x => x.Value).ThenByDescending(u => u.Key))
            {
                Console.WriteLine($"- {itemm.Key}; Rarity: {itemm.Value}; Rating: {plantNameAverageRating[itemm.Key][0]:f2}");
            }
        }
    }
}