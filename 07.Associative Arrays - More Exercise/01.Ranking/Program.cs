using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> nameAndContesstWithPoints = new SortedDictionary<string, Dictionary<string, int>>();
            string inputContest = string.Empty;
            string[] separator = { "=>" };
            while ((inputContest = Console.ReadLine()) != "end of contests")
            {
                string[] str = inputContest.Split(':');
                string contest = str[0];
                string password = str[1];
                contestAndPassword.Add(contest, password);
            }
            string inputCollection = string.Empty;
            while ((inputCollection = Console.ReadLine()) != "end of submissions")
            {
                string[] str2 = inputCollection.Split(separator, StringSplitOptions.None);
                string contestFromCollection = str2[0];
                string passwordFromCollection = str2[1];
                string nameCollection = str2[2];
                int pointFromCollection = int.Parse(str2[3]);
                if (contestAndPassword.ContainsKey(contestFromCollection)
                    && contestAndPassword.ContainsValue(passwordFromCollection))
                {
                    if (nameAndContesstWithPoints.ContainsKey(nameCollection) == false)
                    {
                        nameAndContesstWithPoints.Add(nameCollection, new Dictionary<string, int>());
                        nameAndContesstWithPoints[nameCollection].Add(contestFromCollection, pointFromCollection);
                    }
                    if (nameAndContesstWithPoints[nameCollection].ContainsKey(contestFromCollection))
                    {
                        if (nameAndContesstWithPoints[nameCollection][contestFromCollection] < pointFromCollection)
                        {
                            nameAndContesstWithPoints[nameCollection][contestFromCollection] = pointFromCollection;
                        }
                    }
                    else
                    {
                        nameAndContesstWithPoints[nameCollection].Add(contestFromCollection, pointFromCollection);
                    }
                }

            }
            Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();
            foreach (var kvp in nameAndContesstWithPoints)
            {
                usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            string bestName = usernameTotalPoints
                .Keys
                .Max();
            int bestPoints = usernameTotalPoints
                .Values
                .Max();

            foreach (var kvp in usernameTotalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }
            Console.WriteLine("Ranking:");
            foreach (var name in nameAndContesstWithPoints)
            {
                Dictionary<string, int> dict = name.Value;
                dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine("{0}", name.Key);
                foreach (var kvp in dict)
                {
                    Console.WriteLine("#  {0} -> {1}", kvp.Key, kvp.Value);
                }

            }
        }
    }
}