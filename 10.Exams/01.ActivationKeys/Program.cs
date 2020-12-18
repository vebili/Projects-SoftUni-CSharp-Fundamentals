using System;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            string command = Console.ReadLine();
            
            while (command != "Generate")
            {
                string[] arguments = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                int startIndex;
                int endIndex;
                switch (action)
                {
                    case "Contains":
                        string substring = arguments[1];
                        if (rawKey.Contains(substring))
                        {
                            Console.WriteLine($"{rawKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string subCommand = arguments[1];
                        startIndex = int.Parse(arguments[2]);
                        endIndex = int.Parse(arguments[3]);

                        if (subCommand == "Upper")
                        {
                            rawKey = rawKey.Substring(0, startIndex) + rawKey.Substring(startIndex, endIndex - startIndex).ToUpper() + rawKey.Substring(endIndex);
                            Console.WriteLine(rawKey);
                        }
                        else if (subCommand == "Lower")
                        {
                            rawKey = rawKey.Substring(0, startIndex) + rawKey.Substring(startIndex, endIndex - startIndex).ToLower() + rawKey.Substring(endIndex);

                            Console.WriteLine(rawKey);
                        }
                        break;
                    case "Slice":
                        startIndex = int.Parse(arguments[1]);
                        endIndex = int.Parse(arguments[2]);
                        rawKey = rawKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(rawKey);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}