using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To find the numbers are equal or not");
            Console.WriteLine("Enter the first number");
            int integerOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int integerTwo = Convert.ToInt32(Console.ReadLine());
            if (integerOne == integerTwo)
            {
                Console.WriteLine("They are Equal");
            }
            else
            {
                Console.WriteLine("They are not Equal");
            }
            //Console.ReadLine();
            Console.WriteLine ( "\r\n\r\n");

            Console.WriteLine("To find the numbers are positive or negative");
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

            //Console.ReadLine();
            Console.WriteLine("\r\n\r\n");
            Console.WriteLine("To get 2 numbers from the user and then perform (+,/,-,*)");
            // Prompt user to enter the first number
            Console.WriteLine("Enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            // Prompt user to enter the second number
            Console.WriteLine("Enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Perform addition
            int sum = number1 + number2;
            Console.WriteLine($"Sum of {number1} and {number2} is: {sum}");

            // Perform subtraction
            int difference = number1 - number2;
            Console.WriteLine($"Difference of {number1} and {number2} is: {difference}");

            // Perform multiplication
            int product = number1 * number2;
            Console.WriteLine($"Product of {number1} and {number2} is: {product}");

            // Perform division (considering integer division for simplicity)
            // Ensure number2 is not zero to avoid division by zero error
            if (number2 != 0)
            {
                int quotient = number1 / number2;
                Console.WriteLine($"Quotient of {number1} divided by {number2} is: {quotient}");
            }
            else
            {
                Console.WriteLine("Division by zero is not defined.");
            }

            Console.ReadLine();
        }
    }
}
