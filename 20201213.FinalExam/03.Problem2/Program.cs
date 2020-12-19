using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> userEmail = new Dictionary<string, List<string>>();            
            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] splitInput = input.Split("->");
                string command = splitInput[0];
                if (command == "Add")
                {
                    string username = splitInput[1];
                    if (userEmail.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        userEmail.Add(username, new List<string>());
                    }
                }
                else if (command == "Send")
                {
                    string username = splitInput[1];
                    string email = splitInput[2];
                    if (userEmail.ContainsKey(username))
                    {
                        userEmail[username].Add(email);
                    }
                    else
                    {
                        userEmail.Add(username, new List<string>());
                        userEmail[username].Add(email);
                    }
                }
                else if (command == "Delete")
                {
                    string username = splitInput[1];
                    if (userEmail.ContainsKey(username))
                    {
                        userEmail.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Users count: {userEmail.Count}");
            foreach (var item in userEmail.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var mails in item.Value)
                {
                    Console.WriteLine($" - {mails}");
                }
            }
        }
    }
}
