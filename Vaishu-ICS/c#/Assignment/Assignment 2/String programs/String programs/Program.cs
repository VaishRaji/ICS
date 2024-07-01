using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Display the length of a word.");
                Console.WriteLine("2. Display the reverse of a word.");
                Console.WriteLine("3. Check if two words are the same.");
                Console.WriteLine("4. Exit the program.");
                Console.WriteLine("Enter your choice (1-4):");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        DisplayLengthOfWord();
                        break;
                    case 2:
                        DisplayReverseOfWord();
                        break;
                    case 3:
                        CheckIfWordsAreSame();
                        break;
                    case 4:
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }

                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DisplayLengthOfWord()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            int length = word.Length;
            Console.WriteLine($"Length of the word '{word}' is: {length}");
        }

        static void DisplayReverseOfWord()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            Console.WriteLine($"Reverse of the word '{word}' is: {reversedWord}");
        }

        static void CheckIfWordsAreSame()
        {
            Console.WriteLine("Enter the first word:");
            string word1 = Console.ReadLine().ToLower(); 

            Console.WriteLine("Enter the second word:");
            string word2 = Console.ReadLine().ToLower(); 

            if (string.Equals(word1, word2))
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are the same.");
            }
            else
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are different.");
            }
        }
    }
}
       
