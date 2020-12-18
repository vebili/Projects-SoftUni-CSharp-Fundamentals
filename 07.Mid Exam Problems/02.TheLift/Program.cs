using System;
using System.Linq;

namespace _02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            bool spots = false;
            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (lift[i] < 4)
                    {
                        if (people == 0)
                        {
                            break;
                        }
                        lift[i] += 1;
                        people -= 1;
                    }
                }
                if (lift[i] < 4)
                {
                    spots = true;
                }
            }
            if (people == 0 && spots)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', lift));
            }
            else if (people > 0 && !spots)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(' ', lift));
            }
            else
            {
                Console.WriteLine(string.Join(' ', lift));
            }
        }
    }
}
