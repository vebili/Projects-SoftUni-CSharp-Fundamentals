using System;

namespace _01.Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();
            string cmd = Console.ReadLine();

            while (cmd != "For Azeroth")
            {
                string[] currentcmd = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = currentcmd[0];

                if (command == "GladiatorStance")
                {
                    skill = skill.ToUpper();
                    Console.WriteLine(skill);
                }
                else if (command == "DefensiveStance")
                {
                    skill = skill.ToLower();
                    Console.WriteLine(skill);
                }
                else if (command == "Dispel")
                {
                    int index = int.Parse(currentcmd[1]);
                    char ch = char.Parse(currentcmd[2]);

                    if (index < 0 || index >= skill.Length)
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                    else
                    {
                        char charToReplace = skill[index];
                        skill = skill.Replace(charToReplace, ch);
                        Console.WriteLine("Success!");
                    }
                }
                else if (currentcmd[0] + " " + currentcmd[1] == "Target Change")
                {
                    string subs = currentcmd[2];
                    string secondSubs = currentcmd[3];

                    skill = skill.Replace(subs, secondSubs);
                    Console.WriteLine(skill);
                }
                else if (currentcmd[0] + " " + currentcmd[1] == "Target Remove")
                {
                    string subsToRemove = currentcmd[2];
                    int sus = skill.IndexOf(subsToRemove);
                    int endIndex = subsToRemove.Length;
                    skill = skill.Remove(sus, endIndex);
                    Console.WriteLine(skill);
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
                cmd = Console.ReadLine();
            }
        }
    }
}