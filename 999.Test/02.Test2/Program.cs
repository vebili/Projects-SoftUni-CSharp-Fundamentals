using System;
using System.Text.RegularExpressions;

namespace _02.Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(.+)>(?<nums>[0-9]{3})\|(?<low>[a-z]{3})\|(?<up>[A-Z]{3})\|(?<except>[^<>]{3})<\1";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match matchPass = Regex.Match(input, pattern);

                if (matchPass.Success)
                {
                    string nums = matchPass.Groups["nums"].Value;
                    string low = matchPass.Groups["low"].Value;
                    string up = matchPass.Groups["up"].Value;
                    string except = matchPass.Groups["except"].Value;
                    string concatedPass = string.Concat(nums, low, up, except);
                    Console.WriteLine($"Password: {concatedPass}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}