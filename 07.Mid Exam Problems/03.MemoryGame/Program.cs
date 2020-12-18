using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();
            string input = Console.ReadLine();
            int moves = 0;
            while (input != "end")
            {
                int[] indexes = input
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
                int index1 = indexes[0];
                int index2 = indexes[1];
                if (index1 >= sequence.Count || index1 < 0 || index2 >= sequence.Count || index2 < 0 || index1 == index2)
                {
                    moves++;
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    string[] addOn = { $"-{moves}a", $"-{moves}a" };
                    sequence.InsertRange(sequence.Count / 2, addOn);
                }
                else if (sequence[index1] == sequence[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequence[index1]}!");
                    if (index1 > index2)
                    {
                        sequence.RemoveAt(index1);
                        sequence.RemoveAt(index2);
                    }
                    else if (index2 > index1)
                    {
                        sequence.RemoveAt(index2);
                        sequence.RemoveAt(index1);
                    }
                    moves++;
                }
                else if (sequence[index1] != sequence[index2])
                {
                    Console.WriteLine("Try again!");
                    moves++;
                }
                if (sequence.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (sequence.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', sequence));
            }
        }
    }
}
