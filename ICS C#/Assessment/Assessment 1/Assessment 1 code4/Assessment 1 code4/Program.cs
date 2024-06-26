using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_code4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();


            string result = ExchangeFirstAndLastCharacters(userInput);
            Console.WriteLine($"Modified string: {result}");
            Console.ReadLine();
        }

        static string ExchangeFirstAndLastCharacters(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
            {
                return input;
            }

            char firstChar = input[0];
            char lastChar = input[input.Length - 1];
            string middle = input.Substring(1, input.Length - 2);

            return lastChar + middle + firstChar;
        }
    }
}
