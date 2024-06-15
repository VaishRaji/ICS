using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.checkEqualNumber();   
        }
        public void checkEqualNumber()
        {
            Console.WriteLine("Enter the number:");
            string input = Console.ReadLine();
            double number;
            if (double.TryParse(input, out number))
            {
                if (number > 0)
                {
                    Console.WriteLine("the number is positive");
                }
                else if (number < 0)
                {
                    Console.WriteLine("the number is negative");
                }
                else
                { Console.WriteLine("the number is zero"); }

            }
            else
            {
                Console.WriteLine("invalid input,please enter a valid number");
            }
            Console.ReadLine();
            
        }
    }
}
