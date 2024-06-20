using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail
{
    class Program
    {
        static void Main()
        {
            int minVal = int.MaxValue;
            foreach (int num in arr)
            {
                if (num < minVal)
                {
                    minVal = num;
                }
            }
            return minVal;
        }
        //Console.ReadLine();
        Console.WriteLine( "\r\n\r\n");

        static int FindMaximum(int[] arr)
        {
            int maxVal = int.MinValue;
            foreach (int num in arr)
            {
                if (num > maxVal)
                {
                    maxVal = num;
                }
            }
            return maxVal;

            // Array to store ten marks
            int[] marks = new int[10];

            // Prompt user to enter ten marks
            Console.WriteLine("Enter ten marks:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out marks[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer mark.");
                    Console.Write($"Enter mark {i + 1}: ");
                }
            }

            // Calculate total and average marks
            int total = CalculateTotal(marks);
            double average = CalculateAverage(marks);

            // Find minimum and maximum marks
            int minimum = FindMinimum(marks);
            int maximum = FindMaximum(marks);

            // Sort marks in ascending order
            int[] ascendingOrder = SortAscending(marks);

            // Sort marks in descending order
            int[] descendingOrder = SortDescending(marks);

            // Display results
            Console.WriteLine($"\nTotal marks: {total}");
            Console.WriteLine($"Average marks: {average}");
            Console.WriteLine($"Minimum marks: {minimum}");
            Console.WriteLine($"Maximum marks: {maximum}");

            Console.WriteLine("\nMarks in ascending order:");
            PrintArray(ascendingOrder);

            Console.WriteLine("\nMarks in descending order:");
            PrintArray(descendingOrder);

            // Wait for user input before closing the console window
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static int CalculateTotal(int[] marks)
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return sum;
        }

        static double CalculateAverage(int[] marks)
        {
            return CalculateTotal(marks) / (double)marks.Length;
        }

        static int FindMinimum(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min)
                {
                    min = mark;
                }
            }
            return min;
        }

        static int FindMaximum(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark > max)
                {
                    max = mark;
                }
            }
            return max;
        }

        static int[] SortAscending(int[] marks)
        {
            int[] ascending = new int[marks.Length];
            Array.Copy(marks, ascending, marks.Length);
            Array.Sort(ascending);
            return ascending;
        }

        static int[] SortDescending(int[] marks)
        {
            int[] descending = new int[marks.Length];
            Array.Copy(marks, descending, marks.Length);
            Array.Sort(descending);
            Array.Reverse(descending);
            return descending;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            //Console.ReadLine();
            Console.WriteLine("\r\n\r\n");

            // Source array
            int[] sourceArray = { 1, 2, 3, 4, 5 };

            // Destination array (same size as source array)
            int[] destinationArray = new int[sourceArray.Length];

            // Copy elements from source to destination
            CopyArray(sourceArray, destinationArray);

            // Print original and copied arrays
            Console.WriteLine("Original Array:");
            PrintArray(sourceArray);

            Console.WriteLine("\nCopied Array:");
            PrintArray(destinationArray);

            // Wait for user input before closing the console window
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        static void CopyArray(int[] source, int[] destination)
        {
            // Check if arrays are of the same length
            if (source.Length != destination.Length)
            {
                Console.WriteLine("Arrays must be of the same length to copy elements.");
                return;
            }

            // Copy elements one by one
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}



