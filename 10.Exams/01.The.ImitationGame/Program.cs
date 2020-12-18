using System;

namespace _01.The.ImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] token = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string operation = token[0];

                if (operation == "Move")
                {
                    int numberOfLetter = int.Parse(token[1]);//lenght
                    string str = input.Substring(0, numberOfLetter);
                    input = input.Remove(0, numberOfLetter);
                    //input = input.Replace(str, "");
                    input = input.Insert(input.Length, str);

                }
                else if (operation == "Insert")
                {
                    int index = int.Parse(token[1]);
                    string value = token[2];

                    input = input.Insert(index, value);


                }
                else if (operation == "ChangeAll")
                {
                    string substring = token[1];
                    string replacment = token[2];

                    input = input.Replace(substring, replacment);

                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}