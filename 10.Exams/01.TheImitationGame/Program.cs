using System;
using System.Linq;

namespace _01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] splitted = input.Split("|").ToArray();
                switch (splitted[0])
                {
                    case "Move":
                        int count = int.Parse(splitted[1]);
                        string curr = message.Substring(0, count);
                        message = message.Remove(0, count);
                        message = message.Insert(message.Length, curr);
                        break;
                    case "Insert":
                        int index = int.Parse(splitted[1]);
                        string letter = splitted[2];
                        if (index >= 0)
                        {
                            message = message.Insert(index, letter);
                        }
                        break;
                    case "ChangeAll":
                        char substring = char.Parse(splitted[1]);
                        char replacement = char.Parse(splitted[2]);
                        message = message.Replace(substring, replacement);
                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}