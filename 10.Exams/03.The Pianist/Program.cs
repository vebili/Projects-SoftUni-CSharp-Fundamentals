using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> pieceAndComposer = new Dictionary<string, string>();
            Dictionary<string, string> pieceAndKey = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                pieceAndComposer.Add(input[0], input[1]);
                pieceAndKey.Add(input[0], input[2]);

            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] arguments = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                string piece = arguments[1];
                switch (action)
                {
                    case "Add":
                        string composer = arguments[2];
                        string key = arguments[3];
                        if (pieceAndComposer.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            pieceAndComposer.Add(piece, composer);
                            pieceAndKey.Add(piece, key);
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (pieceAndComposer.ContainsKey(piece))
                        {
                            pieceAndComposer.Remove(piece);
                            pieceAndKey.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        string newKey = arguments[2];
                        if (pieceAndKey.ContainsKey(piece))
                        {
                            pieceAndKey[piece] = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var item in pieceAndComposer.OrderBy(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value}, Key: {pieceAndKey[item.Key]}");
            }
        }
    }
}