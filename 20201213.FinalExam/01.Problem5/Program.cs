using System;

namespace _01.Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Sign up")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                switch (action)
                {
                    case "Case":
                        string casing = arguments[1];
                        if (casing == "lower")
                        {
                            username = username.ToLower();
                        }
                        else if (casing == "upper")
                        {
                            username = username.ToUpper();
                        }
                        Console.WriteLine(username);
                        break;
                    case "Reverse":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        if (startIndex >= 0 && endIndex > startIndex && endIndex < username.Length)
                        {
                            string substr = username.Substring(startIndex, (endIndex - startIndex) + 1);
                            string reversed = string.Empty;
                            for (int i = substr.Length - 1; i >= 0; i--)
                            {
                                reversed += substr[i];
                            }
                            Console.WriteLine(reversed);
                        }
                        break;
                    case "Cut":
                        string substring = arguments[1];
                        if (username.Contains(substring))
                        {
                            int index = username.IndexOf(substring);
                            //username = username.Remove(index, substring.Length);
                            username = username.Replace(substring, "");
                            Console.WriteLine(username);
                        }
                        else
                        {
                            Console.WriteLine($"The word {username} doesn't contain {substring}.");
                        }
                        break;
                    case "Replace":
                        string ch = arguments[1];
                        username = username.Replace(ch, "*");
                        Console.WriteLine(username);
                        break;
                    case "Check":
                        string currentCh = arguments[1];
                        if (username.Contains(currentCh))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {currentCh}.");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}