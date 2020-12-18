using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double priceTotal = 0;

            switch (groupType)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        price = 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        price = 10.46;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        price = 16;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15;
                    }
                    else if (day == "Saturday")
                    {
                        price = 20;
                    }
                    else if (day == "Sunday")
                    {
                        price = 22.50;
                    }
                    break;
            }
            priceTotal = price * group;
            if (group >= 30 && groupType == "Students")
            {
                priceTotal *= 0.85;
            }
            if (group >= 100 && groupType == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        priceTotal -= 10 * 10.90; break;
                    case "Saturday":
                        priceTotal -= 10 * 15.60; break;
                    case "Sunday":
                        priceTotal -= 10 * 16; break;
                }
            }
            if (group >= 10 && group <= 20 && groupType == "Regular")
            {
                priceTotal *= 0.95;
            }
            Console.WriteLine($"Total price: {priceTotal:f2}");
        }
    }
}
