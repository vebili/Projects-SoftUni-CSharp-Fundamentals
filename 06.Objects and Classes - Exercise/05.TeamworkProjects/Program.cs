using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Team
    {
        public string teamName { get; set; }
        public string creatorName { get; set; }
        public List<string> members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < teamsCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split('-').ToArray();
                List<string> membersList = new List<string>();
                Team team = new Team();
                team.teamName = newTeam[1];
                team.creatorName = newTeam[0];
                team.members = membersList;
                if (!teams.Select(x => x.teamName).Contains(team.teamName))
                {
                    if (!teams.Select(x => x.creatorName).Contains(team.creatorName))
                    {
                        teams.Add(team);
                        Console.WriteLine("Team {0} has been created by {1}!", newTeam[1], newTeam[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0} cannot create another team!", team.creatorName);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} was already created!", team.teamName);
                }
            }

            string teamRegister = Console.ReadLine();

            while (teamRegister != "end of assignment")
            {
                var split = teamRegister.Split(new char[] { '-', '>' }).ToArray();
                string newUser = split[0];
                string teamName = split[2];
                if (!teams.Select(x => x.teamName).Contains(teamName))
                {
                    Console.WriteLine("Team {0} does not exist!", teamName);
                }
                else if (teams.Select(x => x.members).Any(x => x.Contains(newUser)) || teams.Select(x => x.creatorName).Contains(newUser))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", newUser, teamName);
                }
                else
                {
                    int teamToJoinIndex = teams.FindIndex(x => x.teamName == teamName);
                    teams[teamToJoinIndex].members.Add(newUser);
                }

                teamRegister = Console.ReadLine();
            }

            var teamsToDisband = teams.OrderBy(x => x.teamName).Where(x => x.members.Count == 0);
            var fullTeams = teams.
            OrderByDescending(x => x.members.Count).
            ThenBy(x => x.teamName).
            Where(x => x.members.Count > 0);

            foreach (var team in fullTeams)
            {
                Console.WriteLine($"{team.teamName}");
                Console.WriteLine($"- {team.creatorName}");
                foreach (var member in team.members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsToDisband)
            {
                Console.WriteLine(item.teamName);
            }
        }
    }
}