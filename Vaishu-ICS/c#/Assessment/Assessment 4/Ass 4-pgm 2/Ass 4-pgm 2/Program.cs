using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_4_pgm_2
{
    public delegate int CalculatorOperation(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorOperation add = Add;
            CalculatorOperation subtract = Subtract;
            CalculatorOperation multiply = Multiply;

            try
            {
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int resultAdd = PerformOperation(num1, num2, add);
                Console.WriteLine($"Addition Result: {resultAdd}");
                int resultSubtract = PerformOperation(num1, num2, subtract);
                Console.WriteLine($"Subtraction Result: {resultSubtract}");
                int resultMultiply = PerformOperation(num1, num2, multiply);
                Console.WriteLine($"Multiplication Result: {resultMultiply}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            
            Console.ReadKey();
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static int PerformOperation(int x, int y, CalculatorOperation operation)
        {
            return operation(x, y);
        }

    }

}
       
