using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1PerHour = int.Parse(Console.ReadLine());
            int employee2PerHour = int.Parse(Console.ReadLine());
            int employee3PerHour = int.Parse(Console.ReadLine());
            int allStudents = int.Parse(Console.ReadLine());

            int totalPerHour = employee1PerHour + employee2PerHour + employee3PerHour;
            int totalTimeWithoutBreak = allStudents / totalPerHour;
            int totalTime = 0;
            while (true)
            {
                if (allStudents <= 0)
                {
                    break;
                }
                totalTime++;
                if (totalTime % 4 == 0)
                {
                    totalTime++;
                }

                allStudents -= totalPerHour;
            }
            Console.WriteLine($"Time needed: {totalTime}h.");
        }
    }
}