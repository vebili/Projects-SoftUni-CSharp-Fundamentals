using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volumeOfPyramid = (lenght * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volumeOfPyramid:f2}");
        }
    }
}
