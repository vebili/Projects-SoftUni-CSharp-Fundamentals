using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            string command = Console.ReadLine().ToUpper();
            while (command != "END")
            {
                string[] commandArr = command.Split();
                bool isContain = num.Contains(int.Parse(commandArr[1]));
                switch (commandArr[0])
                {
                    case "DELETE":
                        if (isContain)
                        {
                            for (int i = 0; i < num.Count; i++)
                            {
                                num.Remove(int.Parse(commandArr[1]));
                            }
                        }
                        break;
                    case "INSERT":
                        num.Insert(int.Parse(commandArr[2]), int.Parse(commandArr[1]));
                        break;
                }
                command = Console.ReadLine().ToUpper();
            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
