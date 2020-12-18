using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var regexForKey = new Regex(@"[starSTAR]");
            var regexForDecrypt = new Regex(@"@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attack>A|D)![^@\-!:>]*->(?<soldierCount>\d+)");
            var listAttackedPlanets = new List<string>();
            var listDestroyedPlanets = new List<string>();
            int linesNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < linesNumber; i++)
            {
                string message = Console.ReadLine();
                MatchCollection matches = regexForKey.Matches(message);//need a collection!
                int key = matches.Count;
                string decryptedMessage = string.Empty;
                foreach (char symbol in message)
                {
                    int decryptedSymbolInt = symbol - key;
                    char decryptedSymbol = (char)decryptedSymbolInt;
                    decryptedMessage += decryptedSymbol;
                }
                Match newMatch = regexForDecrypt.Match(decryptedMessage);//NB! don't need a collection!
                if (regexForDecrypt.IsMatch(decryptedMessage))
                {
                    string planet = newMatch.Groups["planet"].Value;
                    string attack = newMatch.Groups["attack"].Value;
                    if (attack == "A")
                    {
                        listAttackedPlanets.Add(planet);
                    }

                    else if (attack == "D")
                    {
                        listDestroyedPlanets.Add(planet);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {listAttackedPlanets.Count()}");
            foreach (var planet in listAttackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {listDestroyedPlanets.Count()}");
            foreach (var planet in listDestroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}