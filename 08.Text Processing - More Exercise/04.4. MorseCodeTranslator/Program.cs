using System;
using System.Collections.Generic;
using System.Text;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCode = new Dictionary<string, char>()
            {
                {".-", 'A'}, {"-.", 'N'},
                {"-...", 'B'}, {"---", 'O'},
                {"-.-.", 'C'}, {".--.", 'P'},
                {"-..", 'D'}, {"--.-", 'Q'},
                {".", 'E'}, {".-.", 'R'},
                {"..-.", 'F'}, {"...", 'S'},
                {"--.", 'G'}, {"-", 'T'},
                {"....", 'H'}, {"..-", 'U'},
                {"..", 'I'}, {"...-", 'V'},
                {".---", 'J'}, {".--", 'W'},
                {"-.-", 'K'}, {"-..-", 'X'},
                {".-..", 'L'}, {"-.--", 'Y'},
                {"--", 'M'}, {"--..", 'Z'}
            };

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "|")
                {
                    output.Append(' ');
                }
                else
                {
                    char newChar = morseCode[input[i]];
                    output.Append(newChar);
                }
            }

            Console.WriteLine(output);
        }
    }
}