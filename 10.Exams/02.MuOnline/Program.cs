using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split("|").ToList();
            int health = 100;
            int bitcouns = 0;
            int countRoom = 0;

            for (int i = 0; i < rooms.Count; i++)
            {
                string command = rooms[i];
                string[] currentCommand = command.Split(" ");
                string monster = currentCommand[0];
                int amount = int.Parse(currentCommand[1]);

                while (health > 0)
                {
                    if (monster == "potion")
                    {
                        countRoom++;
                        health += amount;
                        if (health > 100)
                        {

                            Console.WriteLine($"You healed for {amount} hp.");
                            health = 100;
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {amount} hp.");
                            Console.WriteLine($"Current health: {health} hp.");

                        }
                    }
                    else if (monster == "chest")
                    {
                        countRoom++;
                        bitcouns += amount;
                        Console.WriteLine($"You found {amount} bitcoins.");

                    }
                    else
                    {
                        countRoom++;
                        health -= amount;
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {countRoom}");
                            return;
                        }

                        if (health >= 0)
                        {
                            rooms.IndexOf(monster);
                            Console.WriteLine($"You slayed {monster}.");

                        }
                    }
                    break;
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcouns}");
            Console.WriteLine($"Health: {health}");
        }
    }
}