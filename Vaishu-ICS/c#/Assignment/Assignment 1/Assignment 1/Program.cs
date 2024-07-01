using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Check if a number is positive, negative, or zero");
                Console.WriteLine("2. Check if two numbers are equal");
                Console.WriteLine("3. Swap two numbers");
                Console.WriteLine("4. Display number multiple times using placeholders");
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
                        CheckNumber();
                        break;
                    case 2:
                        CheckEquality();
                        break;
                    case 3:
                        SwapNumbers();
                        break;
                    case 4:
                        DisplayNumberMultipleTimes();
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

        static void CheckNumber()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            Console.ReadLine();
        }

        static void CheckEquality()
        {
            Console.WriteLine("Enter the first number:");
            int integerOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int integerTwo = Convert.ToInt32(Console.ReadLine());

            if (integerOne == integerTwo)
            {
                Console.WriteLine("They are Equal");
            }
            else
            {
                Console.WriteLine("They are not Equal");
            }

            Console.ReadLine();
        }

        static void SwapNumbers()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");

            Console.ReadLine();
        }

        static void DisplayNumberMultipleTimes()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}");

            Console.WriteLine($"{number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}");

            Console.ReadLine();
        }
    }
}
     
