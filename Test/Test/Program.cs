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
            
            // enter the first number
            Console.WriteLine("Enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            // enter the second number
            Console.WriteLine("Enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // addition
            int sum = number1 + number2;
            Console.WriteLine($"Sum of {number1} and {number2} is: {sum}");

            //subtraction
            int difference = number1 - number2;
            Console.WriteLine($"Difference of {number1} and {number2} is: {difference}");

            //multiplication
            int product = number1 * number2;
            Console.WriteLine($"Product of {number1} and {number2} is: {product}");

            //division 
            if (number2 != 0)
            {
                int quotient = number1 / number2;
                Console.WriteLine($"Quotient of {number1} divided by {number2} is: {quotient}");
            }
            else
            {
                Console.WriteLine("Division by zero is not defined.");
            }

            //Console.ReadLine();
            Console.WriteLine("\r\n\r\n");

            Console.WriteLine("To swap 2 numbers");
            Console.WriteLine("Enter the num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapping: num 1 = {num1}, num2 = {num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");

            Console.ReadLine();
            Console.WriteLine("\r\n\r\n");

            Console.WriteLine("Displaying number as a input");

            Console.WriteLine("Enter a number:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            // First set of rows with spaces in between
            Console.WriteLine("{0} {0} {0} {0}", n1);

            // Second set of rows without spaces in between
            Console.WriteLine("{0}{0}{0}{0}", n1);

            Console.WriteLine();

            // Repeat
            Console.WriteLine("{0} {0} {0} {0}", n1);
            Console.WriteLine("{0}{0}{0}{0}", n1);

            Console.ReadLine();

        }
    }
}
