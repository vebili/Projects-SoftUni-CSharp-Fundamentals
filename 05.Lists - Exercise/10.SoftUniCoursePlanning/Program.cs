using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scheduleCourse = Console.ReadLine()
                .Split(", ")
                .ToList();
            string commands = Console.ReadLine();

            while (commands != "course start")
            {
                string[] commandArguments = commands.Split(":").ToArray();
                switch (commandArguments[0])
                {
                    case "Add":
                        if (!scheduleCourse.Contains(commandArguments[1]))
                        {
                            scheduleCourse.Add(commandArguments[1]);
                        }
                        break;

                    case "Insert":
                        if (!scheduleCourse.Contains(commandArguments[1]))
                        {
                            scheduleCourse.Insert(int.Parse(commandArguments[2]), commandArguments[1]);
                        }
                        break;

                    case "Remove":
                        if (scheduleCourse.Contains(commandArguments[1]))
                        {
                            int index = scheduleCourse.IndexOf(commandArguments[1]);

                            if (scheduleCourse.Contains(commandArguments[1] + "-Exercise"))
                            {
                                scheduleCourse.RemoveRange(index, 1);
                            }
                            else
                            {
                                scheduleCourse.Remove(commandArguments[1]);
                            }

                        }
                        break;

                    case "Swap":
                        string lessonTitle1 = commandArguments[1];
                        string lessonTitle2 = commandArguments[2];
                        int index1 = scheduleCourse.IndexOf(lessonTitle1);
                        int index2 = scheduleCourse.IndexOf(lessonTitle2);

                        if (scheduleCourse.Contains(lessonTitle1) && scheduleCourse.Contains(lessonTitle2))
                        {
                            string temp = scheduleCourse.ElementAt(index1);
                            scheduleCourse[index1] = scheduleCourse[index2];
                            scheduleCourse[index2] = temp;
                        }
                        if (scheduleCourse.Contains(lessonTitle1 + "-Exercise") && scheduleCourse.Contains(scheduleCourse[index1]))
                        {
                            index1 = scheduleCourse.IndexOf(lessonTitle1);
                            scheduleCourse.Remove(lessonTitle1 + "-Exercise");
                            scheduleCourse.Insert(index1 + 1, lessonTitle1 + "-Exercise");
                        }
                        else if (scheduleCourse.Contains(lessonTitle2 + "-Exercise") && scheduleCourse.Contains(scheduleCourse[index2]))
                        {
                            index2 = scheduleCourse.IndexOf(lessonTitle2);
                            scheduleCourse.Remove(lessonTitle2 + "-Exercise");
                            scheduleCourse.Insert(index2 + 1, lessonTitle2 + "-Exercise");
                        }
                        break;

                    case "Exercise":
                        string lessonTitle = commandArguments[1];

                        if (scheduleCourse.Contains(lessonTitle) && !scheduleCourse.Contains(lessonTitle + "-Exercise"))
                        {
                            int index = scheduleCourse.IndexOf(lessonTitle);
                            scheduleCourse.Insert(index + 1, lessonTitle + "-Exercise");
                        }
                        else if (!scheduleCourse.Contains(lessonTitle))
                        {
                            scheduleCourse.Add(lessonTitle);
                            scheduleCourse.Add(lessonTitle + "-Exercise");
                        }
                        break;
                }
                commands = Console.ReadLine();
            }
            for (int i = 0; i < scheduleCourse.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{scheduleCourse[i]}");
            }
        }
    }
}