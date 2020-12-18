using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listParticipants = Console.ReadLine()
                .Split(", ");
            Dictionary<string, int> participantsDistance = new Dictionary<string, int>();
            foreach (string name in listParticipants)
            {
                participantsDistance.Add(name, 0);
            }
            string namePatern = @"[\W\d]";
            string numberPattern = @"[\WA-z]";
            string input = Console.ReadLine();
            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePatern, "");
                string number = Regex.Replace(input, numberPattern, "");
                int total = 0;
                foreach (var item in number)
                {
                    int currentNumber = int.Parse(item.ToString());
                    total += currentNumber;
                }
                if (participantsDistance.ContainsKey(name))
                {
                    participantsDistance[name] += total;
                }
                input = Console.ReadLine();
            }
            int count = 1;
            foreach (var item in participantsDistance.OrderByDescending(x => x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count++}{text} place: {item.Key}");
                if (count == 4)
                {
                    break;
                }
            }
        }
    }
}