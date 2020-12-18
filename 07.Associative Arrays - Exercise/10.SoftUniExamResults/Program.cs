using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> student = new Dictionary<string, int>();
            Dictionary<string, int> submission = new Dictionary<string, int>();
            while (input != "exam finished")
            {
                string[] arguments = input.Split("-");
                string user = arguments[0];
                if (arguments.Length > 2)
                {
                    string language = arguments[1];
                    int points = int.Parse(arguments[2]);
                    if (!student.ContainsKey(user))
                    {
                        student.Add(user, points);
                    }
                    else
                    {
                        if (student[user] < points)
                        {
                            student[user] = points;
                        }
                    }
                    if (!submission.ContainsKey(language))
                    {
                        submission.Add(language, 0);
                    }
                    submission[language]++;
                }
                else
                {
                    student.Remove(user);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var currStudent in student.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currStudent.Key} | {currStudent.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var currSubmission in submission.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currSubmission.Key} - {currSubmission.Value}");
            }
        }
    }
}