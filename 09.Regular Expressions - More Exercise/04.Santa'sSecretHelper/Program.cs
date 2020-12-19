using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Santa_sSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string message = Console.ReadLine();
                if (message == "end")
                {
                    break;
                }

                string decoded = string.Empty;
                foreach (char symbol in message)
                {
                    decoded += (char)(symbol - key);
                }

                string pattern = @"@(?<name>[A-Za-z]+)[^@!:>-]*!(?<type>[GN])!";
                Match match = Regex.Match(decoded, pattern);
                if (match.Groups["type"].Value == "G")
                {
                    sb.AppendLine(match.Groups["name"].Value);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}