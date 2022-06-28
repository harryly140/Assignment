using System;
using System.Linq;

namespace Assignment
{
    class Program
    {
        private static string RemoveSimilarCharacters(string s)
        {
            string engAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            engAlphabet = string.Join("", engAlphabet.Where(ch => !s.Contains(ch)));

            return engAlphabet;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter an input up to 256 characters: ");
            string input = Console.ReadLine().ToUpper();

            if (input.Length < 256)
            {
                Console.WriteLine($"Removed characters: {RemoveSimilarCharacters(input)}");
                Console.WriteLine($"Amount of characters in list: {RemoveSimilarCharacters(input).Length}");
            }
            else
            {
                Console.Write("Input length has exceeded 256");
            }
        }
    }
}
