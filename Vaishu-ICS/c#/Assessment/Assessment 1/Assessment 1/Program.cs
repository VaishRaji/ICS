using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Remove character at specific position from a string");
                Console.WriteLine("2. Exchange first and last characters of a string");
                Console.WriteLine("3. Find the largest among three integers");
                Console.WriteLine("4. Print multiplication table for a number");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        RemoveCharacterAtPosition();
                        break;
                    case 2:
                        ExchangeFirstAndLastCharacters();
                        break;
                    case 3:
                        FindLargestAmongThree();
                        break;
                    case 4:
                        PrintMultiplicationTable();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

                Console.WriteLine();
            }
            while (choice != 5);
        }

        static void RemoveCharacterAtPosition()
        {
            Console.Write("Enter the string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the position to remove the character from (0-based index): ");
            int position;
            while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position >= input.Length)
            {
                Console.WriteLine("Invalid input. Position must be a valid integer within the range of the string length.");
                Console.Write("Enter the position to remove the character from (0-based index): ");
            }

            string result = input.Remove(position, 1);
            Console.WriteLine("Result after removing character: " + result);
        }

        static void ExchangeFirstAndLastCharacters()
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput) || userInput.Length == 1)
            {
                Console.WriteLine($"Modified string: {userInput}");
                return;
            }

            char firstChar = userInput[0];
            char lastChar = userInput[userInput.Length - 1];
            string middle = userInput.Substring(1, userInput.Length - 2);

            string result = lastChar + middle + firstChar;
            Console.WriteLine($"Modified string: {result}");
        }

        static void FindLargestAmongThree()
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third integer: ");
            int num3 = int.Parse(Console.ReadLine());

            int largest = num1;

            if (num2 > largest)
            {
                largest = num2;
            }

            if (num3 > largest)
            {
                largest = num3;
            }

            Console.WriteLine("The largest number is: " + largest);
        }

        static void PrintMultiplicationTable()
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }
    }
}
       
