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
            Console.WriteLine("Enter the first value:");
            int integerOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value:");
            int integerTwo = Convert.ToInt32(Console.ReadLine());
            if (integerOne == integerTwo)
            {
                Console.WriteLine("The numbers are equal");

            }
            else
            {
                Console.WriteLine("they are not equal");
            }
            Console.ReadLine();
        }
    }
}
