using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Plant_Discovery
{
    class Program
    {
        class Plant
        {
            public Plant(string plantName, int rarity, List<double> rating)
            {
                PlantName = plantName;
                Rarity = rarity;
                Rating = rating;
            }
            public string PlantName { get; set; }
            public int Rarity { get; set; }
            public List<double> Rating { get; set; }
        }
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string plant = input[0];
                int rarity = int.Parse(input[1]);

                Plant plante = new Plant(plant, rarity, new List<double>());

                if (plante.PlantName == plant)
                {
                    plante.Rarity = rarity;
                }
                else
                {
                    plante.PlantName = plant;
                    plante.Rarity = rarity;
                }

                plants.Add(plante);
            }
            string comand = Console.ReadLine();
            while (comand != "Exhibition")
            {
                string[] input = comand.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string[] cmd = input[0].Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmd[0];
                string plant = cmd[1];

                if (command == "Rate")
                {
                    int rating = int.Parse(input[1]);
                    var matches = plants.Where(p => p.PlantName == plant).ToList();
                    if (matches.Count <= 0)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        foreach (var item in plants)
                        {
                            if (item.PlantName == plant)
                            {
                                item.Rating.Add(rating);
                            }
                        }
                    }
                }
                else if (command == "Update")
                {
                    int newRarity = int.Parse(input[1]);
                    var matches = plants.Where(p => p.PlantName == plant).ToList();

                    if (matches.Count <= 0)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        foreach (var item in plants)
                        {
                            if (item.PlantName == plant)
                            {
                                item.Rarity = newRarity;
                            }
                        }
                    }
                }
                else if (command == "Reset")
                {
                    var matches = plants.Where(p => p.PlantName == plant).ToList();
                    if (matches.Count <= 0)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        foreach (var item in plants)
                        {
                            if (item.PlantName == plant)
                            {
                                item.Rating = new List<double>();
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
                comand = Console.ReadLine();
            }

            foreach (Plant item in plants)
            {
                if (item.Rating.Count > 0)
                {
                    double avg = item.Rating.Average();
                    item.Rating = new List<double>();
                    item.Rating.Add(avg);
                }
                else
                {
                    item.Rating.Add(0);
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant plant in plants.OrderByDescending(x => x.Rarity).ThenByDescending(u => u.Rating[0]))
            {
                Console.WriteLine($"- {plant.PlantName}; Rarity: {plant.Rarity}; Rating: {plant.Rating[0]:f2}");
            }
        }
    }
}