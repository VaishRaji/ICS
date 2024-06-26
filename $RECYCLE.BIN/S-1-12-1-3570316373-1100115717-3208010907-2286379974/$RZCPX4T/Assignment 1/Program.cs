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
            prgm2();
            Console.WriteLine("Enter the number");
            int integerOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
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
            

        }

        public static void prgm2()
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
    }

}

