using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (resourses.ContainsKey(resource))
                {
                    resourses[resource] += quantity;
                }
                else
                {
                    resourses.Add(resource, quantity);
                }
                resource = Console.ReadLine();
            }
            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}