using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string model = null;
            string currentModel = null;
            double radius = 0.0;
            int height = 0;
            double volume = 0.0;
            double currentVolume = 0.0;
            for (int i = 0; i < count; i++)
            {
                currentModel = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                currentVolume = 3.14 * radius * radius * height;
                if (currentVolume > volume)
                {
                    volume = currentVolume;
                    currentVolume = 0;
                    model = currentModel;
                    currentModel = null;
                }
            }
            Console.WriteLine(model);
        }
    }
}
