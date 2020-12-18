using System;

namespace ShootForTheWin2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input;
            int count = 0;

            while ((input = Console.ReadLine()?.ToUpper()) != "END")
            {
                int index = int.Parse(input);

                if (index < 0 || index >= targets.Length || targets[index] == -1)
                {
                   
                    continue;
                }
                int shotTarget = targets[index];
                targets[index] = -1;
                count++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }
                    if (targets[i] > shotTarget)
                    {
                        targets[i] -= shotTarget;
                    }
                    else
                    {
                        targets[i] += shotTarget;
                    }
                }
            }
            Console.WriteLine($"Shot targets: {count} -> { string.Join(' ', targets) }");
        }
    }
}
