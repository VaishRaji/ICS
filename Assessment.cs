using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the position to remove the character from (0-based index): ");
            int position;
            while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position >= input.Length)
            {
                Console.WriteLine("Invalid input. Position must be a valid integer within the range of the string length.");
                Console.Write("Enter the position to remove the character from (0-based index): ");
            }

            string result = RemoveCharacterAtPosition(input, position);
            Console.WriteLine("Result: " + result);

            Console.ReadLine();
        }

        static string RemoveCharacterAtPosition(string input, int position)
        {
            return input.Remove(position, 1);
        }
        
