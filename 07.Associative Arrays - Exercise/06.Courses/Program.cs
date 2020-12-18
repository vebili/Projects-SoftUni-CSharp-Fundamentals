using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseCollection = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command != "end")
            {

                string[] info = command.Split(" : ");
                string course = info[0];
                string name = info[1];
                if (!courseCollection.ContainsKey(course))
                {
                    courseCollection.Add(course, new List<string>() { name });
                }
                else
                {
                    courseCollection[course].Add(name);
                }

                command = Console.ReadLine();
            }

            foreach (var course in courseCollection.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var item in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}