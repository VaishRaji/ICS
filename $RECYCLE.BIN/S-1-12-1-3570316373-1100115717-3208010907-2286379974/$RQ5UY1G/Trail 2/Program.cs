using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail_2
{
    class Program
    {
        static void Main(string[] args)
        {
            gth of the word '{input}' is: { length}
            ");

        Console.WriteLine(); // Add a blank line for separation
        }

        static void DisplayReverseWord()
        {
            Console.WriteLine("To reverse a word");

            Console.Write("Enter a word: ");
            string input = Console.ReadLine(); // Accept input from user

            // Reverse the input string
            string reversed = new string(input.Reverse().ToArray());

            // Display the reversed string
            Console.WriteLine($"Reverse of '{input}' is: {reversed}");

            Console.WriteLine(); // Add a blank line for separation
        }

        static void DisplayCompareWords()
        {
            Console.WriteLine("To compare two words");

            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine(); // Accept the first word from user

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine(); // Accept the second word from user

            // Compare the two words for equality ignoring case
            bool areEqual = word1.Equals(word2, StringComparison.OrdinalIgnoreCase);

            // Display the result
            if (areEqual)
            {
                Console.WriteLine($"'{word1}' and '{word2}' are the same.");
            }
            else
            {
                Console.WriteLine($"'{word1}' and '{word2}' are different.");
            }

            Console.WriteLine(); // Add a blank line for separation
        }   

    }
}

