using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Santa_sGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<int> numbersOfTheHouses = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();
            int currentPosition = 0;

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "Forward")
                {
                    int numberOfSteps = int.Parse(input[1]);
                    if (currentPosition + numberOfSteps < numbersOfTheHouses.Count && currentPosition + numberOfSteps >= 0)
                    {
                        currentPosition += numberOfSteps;
                        numbersOfTheHouses.RemoveAt(currentPosition);
                    }
                }
                else if (command == "Back")
                {
                    int numberOfSteps = int.Parse(input[1]);
                    if (currentPosition - numberOfSteps < numbersOfTheHouses.Count && currentPosition - numberOfSteps >= 0)
                    {
                        currentPosition -= numberOfSteps;
                        numbersOfTheHouses.RemoveAt(currentPosition);
                    }
                }
                else if (command == "Gift")
                {
                    int index = int.Parse(input[1]);
                    int houseNumber = int.Parse(input[2]);
                    if (index >= 0 && index < numbersOfTheHouses.Count)
                    {
                        numbersOfTheHouses.Insert(index, houseNumber);
                        currentPosition = index;
                    }
                }
                else if (command == "Swap")
                {
                    int firstHouse = int.Parse(input[1]);
                    int secondHouse = int.Parse(input[2]);

                    if (numbersOfTheHouses.Contains(firstHouse) && numbersOfTheHouses.Contains(secondHouse))
                    {
                        int indexOfFirst = numbersOfTheHouses.IndexOf(firstHouse);
                        int indexOfSecond = numbersOfTheHouses.IndexOf(secondHouse);
                        numbersOfTheHouses[indexOfFirst] = secondHouse;
                        numbersOfTheHouses[indexOfSecond] = firstHouse;
                    }
                }
            }
            Console.WriteLine($"Position: {currentPosition}");
            Console.WriteLine(string.Join(", ", numbersOfTheHouses));
        }
    }
}