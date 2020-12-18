using System;
using System.Text;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            while (command != "Done")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                switch (action)
                {
                    case "TakeOdd":
                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                sb.Append(password[i]);
                            }
                        }
                        password = sb.ToString();
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(arguments[1]);
                        int length = int.Parse(arguments[2]);
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string substring = arguments[1];
                        string substitute = arguments[2];
                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}