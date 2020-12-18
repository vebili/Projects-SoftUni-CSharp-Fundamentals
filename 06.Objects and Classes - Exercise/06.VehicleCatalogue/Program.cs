using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");
            return sb.ToString().TrimEnd();
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicle> vehicleList = new List<Vehicle>();
            while (input != "End")
            {
                string[] vehicle = input.Split().ToArray();
                string type = vehicle[0];
                string model = vehicle[1];
                string color = vehicle[2];
                int horsePower = int.Parse(vehicle[3]);
                Vehicle newVehicle = new Vehicle(type, model, color, horsePower);
                vehicleList.Add(newVehicle);
                input = Console.ReadLine();
            }
            string modelInput = Console.ReadLine();
            while (modelInput != "Close the Catalogue")
            {
                Vehicle printCar = vehicleList.First(x => x.Model == modelInput);
                Console.WriteLine(printCar);
                modelInput = Console.ReadLine();
            }
            List<Vehicle> cars = vehicleList.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucks = vehicleList.Where(x => x.Type == "truck").ToList();
            double totalCarHP = cars.Sum(x => x.HorsePower);
            double totalTruckHP = trucks.Sum(x => x.HorsePower);
            double averageCarHP = 0.00;
            double averageTruckHP = 0.00;
            if (cars.Count > 0)
            {
                averageCarHP = totalCarHP / cars.Count;
            }
            if (trucks.Count > 0)
            {
                averageTruckHP = totalTruckHP / trucks.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarHP:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:F2}.");
        }
    }
 }