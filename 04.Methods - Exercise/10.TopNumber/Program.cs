using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                string current = i.ToString();
                int sum = 0;
                bool isOdd = false;
                foreach (var item in current)
                {
                    int parsed = (int)item;
                    if (parsed % 2 == 1)
                    {
                        isOdd = true;
                    }
                    sum += parsed;
                }
                if (isOdd && sum % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
