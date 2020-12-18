using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = null;
            int count = 0;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            while (true)
            {
                string passAsk = Console.ReadLine();
                if (password == passAsk)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");

                }
            }
        }
    }
}
