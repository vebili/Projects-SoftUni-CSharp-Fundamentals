using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> totalContestCollection = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> totalPointsOfUsers = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "no more time")
            {
                string[] arguments = input.Split(" -> ");
                string userName = arguments[0];
                string contestName = arguments[1];
                int points = int.Parse(arguments[2]);
                //for totalCollection key will be contestName and values will be user and point of the sub dictionary.
                //in the sub dictionary key will be userName and value will be points of the user.
                //in total points dictionary key will be userName and value will be total points of the user from all contests.
                if (!totalContestCollection.ContainsKey(contestName))
                {
                    totalContestCollection.Add(contestName, new Dictionary<string, int>());

                }
                if (totalContestCollection[contestName].ContainsKey(userName))
                {
                    if (totalContestCollection[contestName][userName] < points)
                    {
                        int diff = points - totalContestCollection[contestName][userName];
                        totalPointsOfUsers[userName] += diff;
                        totalContestCollection[contestName][userName] = points;

                    }
                }
                else
                {
                    totalContestCollection[contestName].Add(userName, points);
                    if (totalPointsOfUsers.ContainsKey(userName))
                    {
                        totalPointsOfUsers[userName] += points;
                    }
                    else
                    {
                        totalPointsOfUsers.Add(userName, points);
                    }
                }

                input = Console.ReadLine();
            }
            int position = 1;
            foreach (var contest in totalContestCollection)
            {
                Console.WriteLine($"{contest.Key}: { contest.Value.Keys.Count} participants");
                foreach (var item in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {

                    Console.WriteLine($"{ position}. { item.Key} <::> { item.Value}");
                    position++;
                }
                position = 1;
            }
            Console.WriteLine("Individual standings:");
            position = 1;
            foreach (var item in totalPointsOfUsers.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{ position}. {item.Key} -> { item.Value}");
                position++;
            }
        }
    }
}