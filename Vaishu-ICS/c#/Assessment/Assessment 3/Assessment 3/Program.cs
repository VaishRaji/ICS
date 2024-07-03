using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Combined Programs");
                Console.WriteLine("1. Calculate Cricket Scores");
                Console.WriteLine("2. Calculate Box Dimensions");
                Console.WriteLine("3. Exit");
                Console.Write("\n Choose a Program(1, 2, or 3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculateIPLCricketScores();
                        break;
                    case "2":
                        CalculateBoxDimensions();
                        break;
                    case "3":
                        Console.WriteLine("Exiting program...");
                        return;
                        break;
                }
            }
        }

        static void CalculateIPLCricketScores()
        {
            Console.Write("Number of matches played: ");
            int no_of_matches = Convert.ToInt32(Console.ReadLine());

            if (no_of_matches > 0)
            {
                double[] scores = new double[no_of_matches];
                double totalSum = 0;

                Console.WriteLine($"Enter scores for {no_of_matches} matches:");
                for (int i = 0; i < no_of_matches; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Match score {i + 1}: ");
                            scores[i] = Convert.ToDouble(Console.ReadLine());
                            totalSum += scores[i];
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid score (numeric value).");
                        }
                    }
                }

                double average = totalSum / no_of_matches;

                Console.WriteLine($"\nSum of scores: {totalSum}");
                Console.WriteLine($"Average score: {average}");
            }
            else
            {
                Console.WriteLine("Number of matches should be greater than zero. Please try again.");
            }
            Console.ReadKey();
        }

        static void CalculateBoxDimensions()
        {
            double length1, breadth1, length2, breadth2;

            Console.Write("Length of Box 1: ");
            length1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Breadth of Box 1: ");
            breadth1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Length of Box 2: ");
            length2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Breadth of Box 2: ");
            breadth2 = Convert.ToDouble(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);
            Box box3 = box1.AddBoxes(box2);

            Console.WriteLine("\nBox 3 details (Box 1 + Box 2):");
            box3.DisplayBoxDetails();

            Console.ReadKey();
        }
    }

    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public Box AddBoxes(Box box2)
        {
            double sumLength = this.Length + box2.Length;
            double sumBreadth = this.Breadth + box2.Breadth;
            return new Box(sumLength, sumBreadth);
        }

        public void DisplayBoxDetails()
        {
            Console.WriteLine($"Box Details - Length: {Length}, Breadth: {Breadth}");
        }
    }
}
