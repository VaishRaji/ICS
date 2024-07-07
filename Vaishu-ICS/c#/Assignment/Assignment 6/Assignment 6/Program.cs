using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate squares of numbers");
            Console.WriteLine("2. Filter words starting with 'a' and ending with 'm'");
            Console.Write("\nEnter your choice (1 or 2): ");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string choiceInput = Console.ReadLine();
            if (!int.TryParse(choiceInput, out int choice))
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                return;
            }

            switch (choice)
            {
                case 1:
                    CalculateSquares();
                    break;
                case 2:
                    FilterWords();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }
            Console.ReadKey();
        }

        public static void CalculateSquares()
        {
            Console.WriteLine("Enter a list of numbers:");
            string input = Console.ReadLine();

            List<int> numbers = input.Split(',')
                                     .Select(str => int.Parse(str.Trim()))
                                     .ToList();

            var result = numbers
                .Select(num => new { Number = num, Square = num * num })
                .Where(pair => pair.Square > 20)
                .ToList();

            Console.WriteLine("\nInput numbers:");
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("\nNumbers and their squares (squares > 20):");
            foreach (var item in result)
            {
                Console.WriteLine($"→ {item.Number} - {item.Square}");
            }
        }

        public static void FilterWords()
        {
            Console.WriteLine("Enter a list of words:");
            string input = Console.ReadLine();

            string[] words = input.Split(',')
                                  .Select(word => word.Trim())
                                  .ToArray();

            var result = words
                .Where(word => word.ToLower().StartsWith("a") && word.ToLower().EndsWith("m"))
                .ToList();

            Console.WriteLine("\nInput words:");
            Console.WriteLine(string.Join(", ", words));

            Console.WriteLine("\nWords starting with 'a' and ending with 'm':");
            if (result.Any())
            {
                Console.WriteLine(string.Join(", ", result));
            }
            else
            {
                Console.WriteLine("No words found starting with 'a' and ending with 'm'.");
            }
        }
    }
}
