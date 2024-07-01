using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Calculate average, minimum, and maximum of an array.");
                Console.WriteLine("2. Analyze ten marks.");
                Console.WriteLine("3. Copy elements from one array to another.");
                Console.WriteLine("4. Exit the program.");
                Console.WriteLine("Enter your choice (1-4):");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ArrayOperations();
                        break;
                    case 2:
                        MarksAnalysis();
                        break;
                    case 3:
                        CopyArray();
                        break;
                    case 4:
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }

                Console.WriteLine("\r\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ArrayOperations()
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine($"Enter {n} integers:");

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            double average = CalculateAverage(array);
            Console.WriteLine($"Average value of array elements: {average}");

            int min = FindMinimum(array);
            int max = FindMaximum(array);
            Console.WriteLine($"Minimum value in array: {min}");
            Console.WriteLine($"Maximum value in array: {max}");
        }

        static void MarksAnalysis()
        {
            int[] marks = new int[10];

            Console.WriteLine("Enter ten marks:");

            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = CalculateTotal(marks);
            Console.WriteLine($"Total marks: {total}");

            double average = CalculateAverage(marks);
            Console.WriteLine($"Average marks: {average}");

            int minMarks = FindMinimum(marks);
            int maxMarks = FindMaximum(marks);
            Console.WriteLine($"Minimum marks: {minMarks}");
            Console.WriteLine($"Maximum marks: {maxMarks}");

            Array.Sort(marks);
            Console.WriteLine("Marks in ascending order:");
            DisplayArray(marks);

            Array.Reverse(marks);
            Console.WriteLine("Marks in descending order:");
            DisplayArray(marks);
        }

        static void CopyArray()
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sourceArray = new int[n];
            int[] destinationArray = new int[n];

            Console.WriteLine($"Enter {n} integers for source array:");

            for (int i = 0; i < n; i++)
            {
                sourceArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                destinationArray[i] = sourceArray[i];
            }

            Console.WriteLine("Elements copied from source to destination array:");
            DisplayArray(destinationArray);
        }

        static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }

        static int FindMinimum(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static int FindMaximum(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static int CalculateTotal(int[] arr)
        {
            int total = 0;
            foreach (int mark in arr)
            {
                total += mark;
            }
            return total;
        }

        static void DisplayArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
       
