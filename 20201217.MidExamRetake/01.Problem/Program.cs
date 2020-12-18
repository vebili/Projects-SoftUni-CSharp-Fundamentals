using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacationDays = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int countOfPeople = int.Parse(Console.ReadLine());
            double priceForFuelPerKm = double.Parse(Console.ReadLine());
            double foodExpensesPerPerson = double.Parse(Console.ReadLine());
            double hotelRoomPricePerNight = double.Parse(Console.ReadLine());

            double food = countOfPeople * foodExpensesPerPerson * vacationDays;
            double hotel = hotelRoomPricePerNight * countOfPeople * vacationDays;
            if (countOfPeople > 10)
            {
                hotel *= 0.75;
            }
            double calcExpenses = food + hotel;

            for (int i = 1; i <= vacationDays; i++)
            {
                double travelDistance = double.Parse(Console.ReadLine());
                calcExpenses += travelDistance * priceForFuelPerKm;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    calcExpenses *= 1.4;
                }
                if (i % 7 == 0)
                {
                    calcExpenses -= calcExpenses / countOfPeople;
                }
                if (budget < calcExpenses)
                {
                    double moneyNeed = calcExpenses - budget;
                    Console.WriteLine($"Not enough money to continue the trip. You need {moneyNeed:F2}$ more.");
                    return;
                }
            }
            double moneyLeft = budget - calcExpenses;
            Console.WriteLine($"You have reached the destination. You have {moneyLeft:F2}$ budget left.");
        }
    }
}