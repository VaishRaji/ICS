using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        public class LetterCounter
        {
            public static int CountOccurrences(string input, char letter)
            {
                int count = 0;
                foreach (char c in input)
                {
                    if (char.ToUpper(c) == char.ToUpper(letter))
                    {
                        count++;
                    }
                }
                return count;
            }

            public static void Main(string[] args)
            {
                Console.WriteLine("Enter a string:");
                string inputString = Console.ReadLine();

                Console.WriteLine("Enter the letter to count:");
                char letterToCount = Console.ReadKey().KeyChar; // Read the first character entered

                int occurrences = CountOccurrences(inputString, letterToCount);

                Console.WriteLine($"\nThe letter '{letterToCount}' appears {occurrences} times in the string '{inputString}'.");

                // Keep the console window open until a key is pressed
                Console.ReadLine();
            }
        }
    }
}

