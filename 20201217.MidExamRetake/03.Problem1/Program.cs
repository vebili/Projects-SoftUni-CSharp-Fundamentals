using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> paintingsNumbers = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string command = input.Split()[0];
                switch (command)
                {
                    case "Change":
                        {
                            string paintingNumber = input.Split()[1];
                            string changedNumber = input.Split()[2];
                            if (paintingsNumbers.Contains(paintingNumber))
                            {
                                int index = paintingsNumbers.IndexOf(paintingNumber);
                                paintingsNumbers[index] = changedNumber;
                            }
                        }
                        break;
                    case "Hide":
                        {
                            string paintingNumber = input.Split()[1];
                            if (paintingsNumbers.Contains(paintingNumber))
                            {
                                paintingsNumbers.Remove(paintingNumber);
                            }
                        }
                        break;
                    case "Switch":
                        {
                            string paintingNumber1 = input.Split()[1];
                            string paintingNumber2 = input.Split()[2];
                            if (paintingsNumbers.Contains(paintingNumber1)
                                && paintingsNumbers.Contains(paintingNumber2))
                            {
                                int index1 = paintingsNumbers.IndexOf(paintingNumber1);
                                int index2 = paintingsNumbers.IndexOf(paintingNumber2);
                                paintingsNumbers[index1] = paintingNumber2;
                                paintingsNumbers[index2] = paintingNumber1;
                            }
                        }
                        break;
                    case "Insert":
                        {
                            int place = int.Parse(input.Split()[1]);
                            string paintingNumber = input.Split()[2];
                            if (place + 1 >= 0 && place + 1 <= paintingsNumbers.Count)
                            {
                                paintingsNumbers.Insert(place + 1, paintingNumber);
                            }
                        }
                        break;
                    case "Reverse":
                        {
                            paintingsNumbers.Reverse();
                        }
                        break;
                    default: break;
                }
            }

            Console.WriteLine(string.Join(" ", paintingsNumbers));
        }
    }
}