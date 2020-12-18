using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> owned = Console.ReadLine()
                .Split(", ")
                .ToList();
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                string[] commands = Console.ReadLine().Split(", ");
                string command = commands[0];
            //    if (command.Length > 6 index = int(commands[1])
            //    {
            //        if (index in range(0, len(owned_cars)):
            //owned_cars.remove(owned_cars[index])
            //    }

            }

        }
    }
}
