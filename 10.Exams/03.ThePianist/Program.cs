using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> parts = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|").ToArray();

                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                if (!parts.ContainsKey(piece))
                {
                    parts[piece] = new List<string>() { "", "" };
                }

                parts[piece][0] = composer;
                parts[piece][1] = key;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("Stop"))
                {
                    break;
                }

                string[] data = input.Split("|").ToArray();
                string command = data[0];

                if (command.Equals("Add"))
                {
                    string piece = data[1];
                    string composer = data[2];
                    string key = data[3];

                    if (parts.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                        continue;
                    }

                    parts[piece] = new List<string>() { "", "" };
                    parts[piece][0] = composer;
                    parts[piece][1] = key;

                    Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                }
                else if (command.Equals("Remove"))
                {
                    string piece = data[1];

                    if (!parts.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        continue;
                    }

                    parts.Remove(piece);
                    Console.WriteLine($"Successfully removed {piece}!");
                }
                else if (command.Equals("ChangeKey"))
                {
                    string piece = data[1];
                    string newKey = data[2];

                    if (!parts.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        continue;
                    }

                    parts[piece][1] = newKey;

                    Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                }
            }
            foreach (var (piece, value) in parts.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
            {
                Console.WriteLine($"{piece} -> Composer: {value[0]}, Key: {value[1]}");
            }
        }
    }
}