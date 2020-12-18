using System;
using System.Linq;

namespace _01.Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string nextLine = "";

            while ((nextLine = Console.ReadLine()) != "Sign up")
            {
                string command = nextLine.Split(" ")[0];

                if (command == "Case")
                {
                    var lowerUpper = nextLine.Split(" ")[1];
                    if (lowerUpper == "lower")
                    {
                        userName = userName.ToLower();
                    }
                    else
                    {
                        userName = userName.ToUpper();
                    }
                    Console.WriteLine(userName);
                }
                else if (command == "Reverse")
                {
                    var startIndex = int.Parse(nextLine.Split(" ")[1]);
                    var endIndex = int.Parse(nextLine.Split(" ")[2]);

                    if (startIndex >= 0 && endIndex <= userName.Length - 1 && startIndex <= endIndex)
                    {
                        int length = endIndex - startIndex;
                        var reverse = userName.Substring(startIndex, length + 1).Reverse().ToArray();
                        Console.WriteLine(reverse);
                    }
                }
                else if (command == "Cut")
                {
                    var substring = nextLine.Split(" ")[1];
                    if (!userName.Contains(substring))
                    {
                        Console.WriteLine($"The word {userName} doesn't contain {substring}.");
                    }
                    else
                    {
                        userName = userName.Replace(substring, "");
                        Console.WriteLine(userName);
                    }
                }
                else if (command == "Replace")
                {
                    var ch = nextLine.Split(" ")[1].ToCharArray()[0];
                    userName = new string(userName.Select(r => r == ch ? '*' : r).ToArray());
                    Console.WriteLine(userName);
                }
                else if (command == "Check")
                {
                    var ch = nextLine.Split(" ")[1].ToCharArray()[0];
                    if (userName.Contains(ch))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {ch}.");
                    }
                }
            }
        }
    }
}