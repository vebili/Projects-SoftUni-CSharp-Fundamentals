using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;
            if (minutes > 59)
            {
                hour += 1;
                if (hour > 23)
                {
                    hour -= 24;
                }
                minutes -= 60;
            }
            if (minutes < 10)
            {
                Console.WriteLine(hour + ":" + "0" + minutes);
            }
            else if (minutes >= 10)
            {
                Console.WriteLine(hour + ":" + minutes);
            }
        }
    }
}
