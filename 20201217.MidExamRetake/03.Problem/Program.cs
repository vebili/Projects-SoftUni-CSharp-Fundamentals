using System;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToList();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string command = input.Split(" ")[0];

                if (command == "Change")
                {
                    int paintingNumber = int.Parse(input.Split(" ")[1]);
                    int changedNumber = int.Parse(input.Split(" ")[2]);

                    if (list.Contains(paintingNumber))
                    {
                        int index = list.IndexOf(paintingNumber);
                        list.RemoveAt(index);
                        list.Insert(index, changedNumber);
                    }
                }
                else if (command == "Hide")
                {
                    int paintingNumber = int.Parse(input.Split(" ")[1]);
                    if (list.Contains(paintingNumber))
                    {
                        list.Remove(paintingNumber);
                    }

                }
                else if (command == "Switch")
                {
                    int paintingNumber1 = int.Parse(input.Split(" ")[1]);
                    int paintingNumber2 = int.Parse(input.Split(" ")[2]);

                    if (list.Contains(paintingNumber1) && list.Contains(paintingNumber2))
                    {
                        int index1 = list.IndexOf(paintingNumber1);
                        int index2 = list.IndexOf(paintingNumber2);

                        list.RemoveAt(index1);
                        list.Insert(index1, paintingNumber2);
                        list.RemoveAt(index2);
                        list.Insert(index2, paintingNumber1);
                    }
                }
                else if (command == "Insert")
                {
                    int place = int.Parse(input.Split(" ")[1]) + 1;
                    int paintingNumber = int.Parse(input.Split(" ")[2]);

                    if (place >= 0 && place < list.Count)
                    {
                        list.Insert(place, paintingNumber);
                    }
                }
                else if (command == "Reverse")
                {
                    list.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}