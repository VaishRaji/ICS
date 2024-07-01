using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Compute the sum of two given integers.");
            Console.WriteLine("2. Read a day number and display the name of the day.");
            Console.WriteLine("Enter your choice (1 or 2):");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                Console.ReadKey();
                return;
            }

            switch (choice)
            {
                case 1:
                    ComputeSum();
                    break;
                case 2:
                    ReadDayName();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }

            Console.WriteLine("\r\nPress any key to exit...");
            Console.ReadKey();
        }

        static void ComputeSum()
        {
            Console.WriteLine("To compute the sum of two given integers.");
            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = SumTripleIfSame(num1, num2);
            Console.WriteLine($"Result: {result}");
        }

        static int SumTripleIfSame(int a, int b)
        {
            int sum = a + b;

            if (a == b)
            {
                return 3 * sum;
            }
            else
            {
                return sum;
            }
        }

        static void ReadDayName()
        {
            Console.WriteLine("To read any day number as an integer and display the name of the day as a word.");
            Console.WriteLine("Enter a day number (1 for Monday, 2 for Tuesday, ..., 7 for Sunday):");

            int dayNumber;
            if (!int.TryParse(Console.ReadLine(), out dayNumber))
            {
                Console.WriteLine("Enter a valid integer");
                return;
            }

            string dayName = GetDayName(dayNumber);

            if (dayName != null)
            {
                Console.WriteLine($"Day name: {dayName}");
            }
            else
            {
                Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
            }
        }

        static string GetDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return null; 
            }
        }
    }
}
