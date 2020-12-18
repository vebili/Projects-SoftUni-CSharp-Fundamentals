using System;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hiddenMess = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] arguments = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                switch (action)
                {
                    case "InsertSpace":
                        int index = int.Parse(arguments[1]);
                        hiddenMess = hiddenMess.Insert(index, " ");
                        Console.WriteLine(hiddenMess);
                        break;
                    case "Reverse":
                        string substr = arguments[1];
                        string reversed = string.Empty;
                        if (hiddenMess.Contains(substr))
                        {
                            int substrIndex = hiddenMess.IndexOf(substr);
                            hiddenMess = hiddenMess.Remove(substrIndex, substr.Length);
                            for (int i = substr.Length - 1; i >= 0; i--)
                            {
                                reversed += substr[i];
                            }
                            hiddenMess = hiddenMess.Insert(hiddenMess.Length, reversed);
                            Console.WriteLine(hiddenMess);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        string substring = arguments[1];
                        string replacementStr = arguments[2];
                        hiddenMess = hiddenMess.Replace(substring, replacementStr);
                        Console.WriteLine(hiddenMess);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {hiddenMess}");
        }
    }
}
