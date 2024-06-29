using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    class Program
    {
        public class Program1
        {
            public abstract class Student
            {
                public string Name { get; set; }
                public int StudentId { get; set; }
                public double Grade { get; set; }
                public abstract bool IsPassed(double grade);
            }
            public class Undergraduate : Student
            {
                public override bool IsPassed(double grade)
                {
                    return grade > 70.0;
                }
            }

            public class Graduate : Student
            {
                public override bool IsPassed(double grade)
                {
                    return grade > 80.0;
                }
            }

            public class Product
            {
                public int ProductId { get; set; }
                public string ProductName { get; set; }
                public double Price { get; set; }
            }

            static void Main()
            {
                int choice;
                do
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Student Evaluation");
                    Console.WriteLine("2. Product Entry and Sorting");
                    Console.WriteLine("3. Check if Number is Positive");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice (1-4): ");

                    if (!int.TryParse(Console.ReadLine(), out choice))

                    switch (choice)
                    {
                        case 1:
                            EvaluateStudent();
                            break;
                        case 2:
                            EnterAndSortProducts();
                            break;
                        case 3:
                            CheckPositiveNumber();
                            break;
                        case 4:
                            Console.WriteLine("End");
                            break;
                    }

                    Console.WriteLine(); 
                }
                while (choice != 4); 
            }

            static void EvaluateStudent()
            {
                Undergraduate undergradStudent = new Undergraduate();
                Console.WriteLine("Enter Undergraduate student's name:");
                undergradStudent.Name = Console.ReadLine();

                Console.WriteLine("Enter Undergraduate student's ID:");
                if (!int.TryParse(Console.ReadLine(), out int undergradId))
                undergradStudent.StudentId = undergradId;

                Console.WriteLine("Enter Undergraduate student's grade:");
                if (!double.TryParse(Console.ReadLine(), out double undergradGrade))
                undergradStudent.Grade = undergradGrade;

                bool undergradPassed = undergradStudent.IsPassed(undergradStudent.Grade);
                Console.WriteLine($"Undergraduate student {undergradStudent.Name} passed: {undergradPassed}");
            }

            static void EnterAndSortProducts()
            {
                Product[] products = new Product[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Enter details for Product {i + 1}:");
                    Product product = new Product();

                    Console.WriteLine("Enter Product ID:");
                    if (!int.TryParse(Console.ReadLine(), out int productId))
                    product.ProductId = productId;

                    Console.WriteLine("Enter Product Name:");
                    product.ProductName = Console.ReadLine();

                    Console.WriteLine("Enter Product Price:");
                    if (!double.TryParse(Console.ReadLine(), out double price))
                    product.Price = price;
                    products[i] = product;
                }

                for (int i = 1; i < products.Length; i++)
                {
                    Product key = products[i];
                    int j = i - 1;

                    while (j >= 0 && products[j].Price > key.Price)
                    {
                        products[j + 1] = products[j];
                        j = j - 1;
                    }
                    products[j + 1] = key;
                }

                Console.WriteLine("\n Sorted Products based on Price:");
                foreach (var product in products)
                {
                    Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
                }
            }
            static void CheckPositiveNumber()
            {
                Console.Write("Enter a number: ");
                int num;

                if (num > 0)
                {
                    Console.WriteLine($"{num} is a Positive Number.");
                }
                else if (num < 0)
                {
                    Console.WriteLine($"{num} is a Negative Number.");
                }
                else
                {
                    Console.WriteLine($"{num} is neither positive nor negative (it's zero).");
                }
            }
        }
       
    }
}
