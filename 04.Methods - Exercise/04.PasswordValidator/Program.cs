using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool length = LengthCheck(input);
            bool leastDigits = LeastDigitsCheck(input);
            bool symbols = SymbolCheck(input);
            if (length && leastDigits && symbols)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!length)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters ");
                }
                if (!symbols)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!leastDigits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        static bool LengthCheck(string lengthPass)
        {
            if (lengthPass.Length >= 6 && lengthPass.Length <= 10)
            {
                return true;
            }
            return false;
        }
        static bool LeastDigitsCheck(string signPass)
        {
            int count = 0;
            for (int i = 0; i < signPass.Length; i++)
            {
                char ch = signPass[i];
                if (char.IsDigit(ch))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            return false;
        }
        static bool SymbolCheck(string symbolPass)
        {
            for (int i = 0; i < symbolPass.Length; i++)
            {
                char ch = symbolPass[i];
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
