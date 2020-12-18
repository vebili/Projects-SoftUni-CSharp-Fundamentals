using System;
using System.Linq;

namespace _01.TrainProper
{
    class Program
    {
        static void Main(string[] args)
        {
            int vagons = int.Parse(Console.ReadLine());
            //int countOfVagoon = 0;
            //int peopleInVagoon = 0;
            int sum = 0;
            int[] peopleInVagoon = new int[vagons];
            for (int i = 0; i < vagons; i++)
            {
                peopleInVagoon[i] = int.Parse(Console.ReadLine());

                sum += peopleInVagoon[i];
            }
            //Console.WriteLine(peopleInVagoon  + " ");
            string result = string.Join(" ", peopleInVagoon);
            Console.WriteLine(result);
            Console.WriteLine(sum);
        }
    }
}
