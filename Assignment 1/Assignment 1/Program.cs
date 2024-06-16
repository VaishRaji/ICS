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
            Console.ReadLine();

        }

    }
}
