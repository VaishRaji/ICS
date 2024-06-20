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
            Console.WriteLine("To compute the sum of two given integers");
            
            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = SumTriple (num1, num2);
            Console.WriteLine("Result: " + result);
            Console.ReadLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            //Console.ReadLine();
            Console.WriteLine("\r\n\r\n");
        }

    }



      