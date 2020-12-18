using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int courses = n / p;
            if (n % p != 0)
            {
                courses += 1;
            }
            Console.WriteLine(courses);
        }
    }
}
