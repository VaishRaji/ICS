using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1_code2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());


            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());


            Console.Write("Enter the third integer: ");
            int num3 = int.Parse(Console.ReadLine());


            int largest = FindLargest(num1, num2, num3);


            Console.WriteLine("The largest number is: " + largest);
            Console.ReadLine();
        }

        static int FindLargest(int a, int b, int c)
        {
            int largest = a;

            if (b > largest)
            {
                largest = b;
            }

            if (c > largest)
            {
                largest = c;
            }

            return largest;
        }
    }
}
