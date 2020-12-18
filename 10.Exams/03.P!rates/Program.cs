using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstCommand = Console.ReadLine();
            Dictionary<string, int> citiesPopulationCollection = new Dictionary<string, int>();
            Dictionary<string, int> citiesGoldCollection = new Dictionary<string, int>();
            while (firstCommand != "Sail")
            {
                string[] arguments = firstCommand.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string city = arguments[0];
                int population = int.Parse(arguments[1]);
                int gold = int.Parse(arguments[2]);
                if (!citiesPopulationCollection.ContainsKey(city))
                {
                    citiesPopulationCollection.Add(city, population);
                    citiesGoldCollection.Add(city, gold);
                }
                else
                {
                    citiesPopulationCollection[city] += population;
                    citiesGoldCollection[city] += gold;
                }
                firstCommand = Console.ReadLine();
            }
            string events = Console.ReadLine();
            int currentGold = 0;
            while (events != "End")
            {
                string[] eventArguments = events.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = eventArguments[0];
                string currentCity = eventArguments[1];

                if (action == "Plunder")
                {
                    currentGold = int.Parse(eventArguments[3]);
                    int currentPeople = int.Parse(eventArguments[2]);
                    citiesGoldCollection[currentCity] -= currentGold;
                    citiesPopulationCollection[currentCity] -= currentPeople;
                    Console.WriteLine($"{currentCity} plundered! {currentGold} gold stolen, {currentPeople} citizens killed.");
                    if (citiesGoldCollection[currentCity] <= 0 || citiesPopulationCollection[currentCity] <= 0)
                    {
                        citiesGoldCollection.Remove(currentCity);
                        //citiesPopulationCollection.Remove(currentCity); removed due to time limit in Softuni Judge System.
                        Console.WriteLine($"{currentCity} has been wiped off the map!");
                    }
                }
                else if (action == "Prosper")
                {
                    currentGold = int.Parse(eventArguments[2]);
                    if (currentGold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        citiesGoldCollection[currentCity] += currentGold;
                        Console.WriteLine($"{currentGold} gold added to the city treasury. {currentCity} now has {citiesGoldCollection[currentCity]} gold.");
                    }
                }
                events = Console.ReadLine();
            }
            if (citiesGoldCollection.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesGoldCollection.Count} wealthy settlements to go to:");
                foreach (var item in citiesGoldCollection.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {citiesPopulationCollection[item.Key]} citizens, Gold: {item.Value} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}