using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();
            while (command != "End")
            {
                string[] info = command.Split(" -> ");
                string company = info[0];
                string id = info[1];
                if (!collection.ContainsKey(company))
                {
                    collection.Add(company, new List<string>() { id });
                }
                else
                {
                    if (!collection[company].Contains(id))
                    {
                        collection[company].Add(id);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var company in collection.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{company.Key}");
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}