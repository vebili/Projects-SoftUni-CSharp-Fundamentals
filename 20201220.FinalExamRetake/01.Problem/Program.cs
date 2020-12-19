using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "For Azeroth")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "GladiatorStance":
                        skill = skill.ToUpper();
                        Console.WriteLine(skill);
                        break;
                    case "DefensiveStance":
                        skill = skill.ToLower();
                        Console.WriteLine(skill);
                        break;
                    case "Dispel":
                        skill = Dispel(skill, cmdArgs);
                        break;
                    case "Target":
                        switch (cmdArgs[1])
                        {
                            case "Change":
                                skill = Change(skill, cmdArgs);
                                break;
                            case "Remove":
                                skill = Remove(skill, cmdArgs);
                                break;
                            default:
                                Console.WriteLine("Command doesn't exist!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Command doesn't exist!");
                        break;
                }
            }
        }
        private static string Remove(string skill, string[] cmdArgs)
        {
            string substring = cmdArgs[2];
            skill = skill.Remove(skill.IndexOf(substring), substring.Length);
            Console.WriteLine(skill);
            return skill;
        }
        private static string Change(string skill, string[] cmdArgs)
        {
            string substring = cmdArgs[2];
            string second = cmdArgs[3];
            skill = skill.Replace(substring, second);
            Console.WriteLine(skill);
            return skill;
        }
        private static string Dispel(string skill, string[] cmdArgs)
        {
            int index = int.Parse(cmdArgs[1]);
            char letter = char.Parse(cmdArgs[2]);
            if (index >= 0 && index < skill.Length)
            {
                skill = skill.Remove(index, 1);
                skill = skill.Insert(index, letter.ToString());
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Dispel too weak.");
            }
            return skill;
        }
    }
}