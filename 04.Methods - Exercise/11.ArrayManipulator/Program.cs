using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index > inputArr.Length - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(inputArr, index);
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        if (MaxEven(inputArr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxEven(inputArr));
                    }
                    else
                    {
                        if (MaxOdd(inputArr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxOdd(inputArr));
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        if (MinEven(inputArr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinEven(inputArr));
                    }
                    else
                    {
                        if (MinOdd(inputArr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinOdd(inputArr));
                    }
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);
                    if (count > inputArr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (command[2] == "even")
                    {
                        FirstEven(inputArr, count);
                    }
                    else
                    {
                        FirstOdd(inputArr, count);
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);
                    if (count > inputArr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (command[2] == "even")
                    {
                        LastEven(inputArr, count);
                    }
                    else
                    {
                        LastOdd(inputArr, count);
                    }
                }
            }
            Console.WriteLine("[" + string.Join(", ", inputArr) + "]");
        }
        static void Exchange(int[] arr, int index)
        {
            //1 3 5 7 9
            //5 7 9 |1 3
            //exchange 1
            //5-1-1 = 3
            //index+1
            int[] firstArr = new int[arr.Length - index - 1];
            int[] secondArr = new int[index + 1];
            int count = 0;
            for (int i = index + 1; i < arr.Length; i++)
            {
                firstArr[count] = arr[i];
                count++;
            }
            for (int i = 0; i <= index; i++)
            {
                secondArr[i] = arr[i];
            }
            for (int i = 0; i < firstArr.Length; i++)
            {
                arr[i] = firstArr[i];
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                arr[index + 1] = secondArr[i];
            }
        }
        static int MaxEven(int[] arr)
        {
            int max = int.MinValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] >= max)
                    {
                        max = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        static int MaxOdd(int[] arr)
        {
            int max = int.MinValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] >= max)
                    {
                        max = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        static int MinEven(int[] arr)
        {
            int min = int.MaxValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] <= min)
                    {
                        min = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        static int MinOdd(int[] arr)
        {
            int min = int.MaxValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] <= min)
                    {
                        min = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        static void FirstEven(int[] arr, int count)
        {
            string numbers = string.Empty;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    numbers += arr[i] + " ";
                    counter++;
                }
                if (counter == count)
                {
                    break;
                }
            }
            string[] result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
        }
        static void FirstOdd(int[] arr, int count)
        {
            string numbers = string.Empty;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    numbers += arr[i] + " ";
                    counter++;
                }
                if (counter == count)
                {
                    break;
                }
            }
            string[] result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
        }
        static void LastEven(int[] arr, int count)
        {
            string numbers = string.Empty;
            int counter = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    counter++;
                    numbers += arr[i] + " ";
                }
                if (counter == count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
        }
        static void LastOdd(int[] arr, int count)
        {
            string numbers = string.Empty;
            int counter = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0)
                {
                    counter++;
                    numbers += arr[i] + " ";
                }
                if (counter == count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
        }
    }
}