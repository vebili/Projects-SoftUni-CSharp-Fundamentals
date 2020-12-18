using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double ivanBudget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double singleSabrePrice = double.Parse(Console.ReadLine());
            double singleRobePrice = double.Parse(Console.ReadLine());
            double singleBeltPrice = double.Parse(Console.ReadLine());
            double Sabre = singleSabrePrice * (Math.Ceiling(studentsCount + studentsCount * 0.1));
            double Robe = singleRobePrice * studentsCount;
            double Belt = singleBeltPrice * (studentsCount - (studentsCount / 6));
            double neededMoney = Sabre + Robe + Belt;
            if (ivanBudget >= neededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {neededMoney - ivanBudget:f2}lv more.");
            }
        }
    }
}
