using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("To accept a word from the user and display the length of it.");
                Console.Write("Enter a word: ");
                string input = Console.ReadLine();

                int length = input.Length;
                Console.WriteLine($"Length of the word '{input}' is: {length}");

                //Console.ReadLine();
                Console.WriteLine("\r\n\r\n");

            }

            {
                Console.WriteLine("To accept a word from the user and display the reverse of it.  ");
                Console.Write("Enter a word: ");
                string input = Console.ReadLine();

                string reversed = new string(input.Reverse().ToArray());
                Console.WriteLine($"Reverse of '{input}' is: {reversed}");
                //Console.ReadLine();
                Console.WriteLine("\r\n\r\n");

            }

            {
                Console.WriteLine("To accept two words from user and find out if they are same. ");
                Console.Write("Enter the first word: ");
                string word1 = Console.ReadLine();
                Console.Write("Enter the second word: ");
                string word2 = Console.ReadLine();

                bool areEqual = word1.Equals(word2, StringComparison.OrdinalIgnoreCase);

                if (areEqual)
                {
                    Console.WriteLine($"'{word1}' and '{word2}' are the same.");
                }
                else
                {
                    Console.WriteLine($"'{word1}' and '{word2}' are different.");
                }

                Console.ReadLine();
            }
        }
    }
}
