using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> carAndMialege = new Dictionary<string, int>();
            Dictionary<string, int> carAndFuel = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                carAndMialege.Add(input[0], int.Parse(input[1]));
                carAndFuel.Add(input[0], int.Parse(input[2]));
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] arguments = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                string currentCar = arguments[1];
                int distance = 0;
                int fuel = 0;
                switch (action)
                {
                    case "Drive":
                        fuel = int.Parse(arguments[3]);
                        distance = int.Parse(arguments[2]);
                        if (carAndFuel[currentCar] < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            carAndFuel[currentCar] -= fuel;
                            carAndMialege[currentCar] += distance;
                            Console.WriteLine($"{currentCar} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                        if (carAndMialege[currentCar] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {currentCar}!");
                            carAndMialege.Remove(currentCar);
                            carAndFuel.Remove(currentCar);
                        }
                        break;
                    case "Refuel":
                        fuel = int.Parse(arguments[2]);
                        carAndFuel[currentCar] += fuel;
                        if (carAndFuel[currentCar] > 75)
                        {
                            Console.WriteLine($"{currentCar} refueled with {75 - (carAndFuel[currentCar] - fuel)} liters");
                            carAndFuel[currentCar] = 75;
                        }
                        else
                        {
                            Console.WriteLine($"{currentCar} refueled with {fuel} liters");
                        }
                        break;
                    case "Revert":
                        distance = int.Parse(arguments[2]);
                        carAndMialege[currentCar] -= distance;
                        if (carAndMialege[currentCar] < 10000)
                        {
                            carAndMialege[currentCar] = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{currentCar} mileage decreased by {distance} kilometers");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var item in carAndMialege.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value} kms, Fuel in the tank: {carAndFuel[item.Key]} lt.");
            }
        }
    }
}