using System;
using System.Text.RegularExpressions;

namespace _02.Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";
            var architectsRegex = new Regex(pattern);

            var architectsCount = int.Parse(Console.ReadLine());

            var name = string.Empty;
            var title = string.Empty;
            var nameLength = 0;
            var titleLength = 0;

            for (var i = 0; i < architectsCount; i++)
            {
                var currentArchitect = Console.ReadLine();
                var matches = Regex.Matches(currentArchitect, pattern);

                if (architectsRegex.IsMatch(currentArchitect))
                {
                    foreach (Match match in matches)
                    {
                        name = match.Groups["name"].Value;
                        title = match.Groups["title"].Value;

                        nameLength = name.Length;
                        titleLength = title.Length;
                    }
                    Console.WriteLine(string.Join(Environment.NewLine,
                        $"{name}, The {title}",
                        $">> Strength: {nameLength}",
                        $">> Armour: {titleLength}"));
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
