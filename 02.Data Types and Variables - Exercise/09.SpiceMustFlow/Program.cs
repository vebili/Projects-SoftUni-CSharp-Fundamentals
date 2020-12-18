using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {            
            int startingYeild = int.Parse(Console.ReadLine());
            
            int totalSpice = 0;
            int days = 0;
            if (startingYeild < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(totalSpice);
            }
            else
            {
                int endDaySpice = 0;
                while (startingYeild >= 100)
                {
                    endDaySpice = startingYeild - 26;
                    totalSpice += endDaySpice;
                    days++;
                    if (days > 0)
                    {
                        startingYeild -= 10;
                    }

                }
                Console.WriteLine(days);
                Console.WriteLine(totalSpice - 26);
            }
        }
    }
}
