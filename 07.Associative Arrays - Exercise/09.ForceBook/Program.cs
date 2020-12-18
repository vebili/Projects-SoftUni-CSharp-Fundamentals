using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<string>>();
            var forceUsers = new List<string>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.IndexOf(" | ") >= 0)
                {
                    string[] tokens = input.Split(" | ");
                    string forceSide = tokens[0];
                    string forceUser = tokens[1];

                    if (!forceUsers.Contains(forceUser))
                    {
                        if (!data.ContainsKey(forceSide))
                        {
                            data.Add(forceSide, new List<string>() { forceUser });
                        }
                        else
                        {
                            data[forceSide].Add(forceUser);
                        }
                    }
                    forceUsers.Add(forceUser);
                }
                else
                {
                    string[] tokens = input.Split(" -> ");
                    string forceUser = tokens[0];
                    string forceSide = tokens[1];
                    if (forceUsers.Contains(forceUser))
                    {
                        string userCurrentSide = string.Empty;
                        foreach (var key in data.Keys)
                        {
                            if (data[key].Contains(forceUser))
                            {
                                userCurrentSide = key;
                                break;
                            }
                        }

                        if (!data.ContainsKey(forceSide))
                        {
                            data[forceSide] = new List<string>();
                        }
                        data[userCurrentSide].Remove(forceUser);
                        data[forceSide].Add(forceUser);
                    }
                    else
                    {
                        if (!data.ContainsKey(forceSide))
                        {
                            data.Add(forceSide, new List<string>() { forceUser });
                        }
                        else
                        {
                            data[forceSide].Add(forceUser);
                        }
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    if (!forceUsers.Contains(forceUser))
                    {
                        forceUsers.Add(forceUser);
                    }
                }
            }
            foreach (var item in data.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                string forceSide = item.Key;
                var members = item.Value;
                if (members.Count > 0)
                {
                    Console.WriteLine($"Side: {forceSide}, Members: {members.Count}");
                    foreach (var member in members.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {member}");
                    }
                }
            }
        }
    }
}