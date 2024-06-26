using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To compute the sum of two given integers.");
            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = SumTripleIfSame(num1, num2);

            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
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
                //Console.ReadLine();
                Console.WriteLine("\r\n\r\n");
            }
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

                Console.ReadKey();
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
                    return null; // Return null for any day number outside 1-7
            }
        }
    }
}


