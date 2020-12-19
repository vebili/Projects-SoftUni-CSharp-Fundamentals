using System;

namespace _01.Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Replace":
                        message = Replace(message, cmdArgs);
                        break;
                    case "Cut":
                        message = Cut(message, cmdArgs);
                        break;
                    case "Make":
                        message = Make(message, cmdArgs);
                        break;
                    case "Check":
                        Check(message, cmdArgs);
                        break;
                    case "Sum":
                        Sum(message, cmdArgs);
                        break;
                    default:
                        break;
                }

            }
        }

        private static void Sum(string message, string[] cmdArgs)
        {
            int startIndex = int.Parse(cmdArgs[1]);
            int endIndex = int.Parse(cmdArgs[2]);
            if (startIndex >= 0 && startIndex < message.Length && endIndex < message.Length)
            {
                int sum = 0;
                string current = message.Substring(startIndex, endIndex - startIndex + 1);
                foreach (var item in current)
                {
                    sum += item;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
            }
        }
        private static void Check(string message, string[] cmdArgs)
        {
            string substring = cmdArgs[1];
            if (message.Contains(substring))
            {
                Console.WriteLine($"Message contains {substring}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {substring}");
            }
        }
        private static string Make(string message, string[] cmdArgs)
        {
            switch (cmdArgs[1])
            {
                case "Upper":
                    message = message.ToUpper();
                    break;
                case "Lower":
                    message = message.ToLower();
                    break;
                default:
                    break;
            }
            Console.WriteLine(message);
            return message;
        }
        private static string Cut(string message, string[] cmdArgs)
        {
            int startIndex = int.Parse(cmdArgs[1]);
            int endIndex = int.Parse(cmdArgs[2]);
            if (startIndex >= 0 && startIndex < message.Length && endIndex < message.Length)
            {
                message = message.Remove(startIndex, endIndex - startIndex + 1);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
            }

            return message;
        }
        private static string Replace(string message, string[] cmdArgs)
        {
            char current = char.Parse(cmdArgs[1]);
            char replacement = char.Parse(cmdArgs[2]);
            message = message.Replace(current, replacement);
            Console.WriteLine(message);
            return message;
        }
    }
}