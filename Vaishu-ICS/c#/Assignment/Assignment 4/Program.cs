using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        public class Books
        { 
            public string BookName { get; set; }
            public string AuthorName { get; set; }

            public Books(string bookName, string authorName)
            {
                BookName = bookName;
                AuthorName = authorName;
            }
            public void Display()
            {
                Console.WriteLine($"Book Name: {BookName}, Author: {AuthorName}");
            }
        }

        public class BookShelf
        {
            private Books[] books;
            public BookShelf()
            {
                books = new Books[5];
            }
            public Books this[int index]
            {
                get
                {
                    return books[index];
                }
                set
                {
                    books[index] = value;
                }
            }
            public void DisplayBooks()
            {
                Console.WriteLine("Books on the Bookshelf:");
                for (int i = 0; i < books.Length; i++)
                {
                    Console.Write($"Book {i + 1}: ");
                    if (books[i] != null)
                    {
                        books[i].Display();
                    }
                    else
                    {
                        Console.WriteLine("No book assigned.");
                    }
                }
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
            public static Box AddBoxes(Box box1, Box box2)
            {
                double newLength = box1.Length + box2.Length;
                double newBreadth = box1.Breadth + box2.Breadth;
                return new Box(newLength, newBreadth);
            }
            public void Display()
            {
                Console.WriteLine($"Box dimensions: Length = {Length}, Breadth = {Breadth}");
            }
        }

        public class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public float Salary { get; set; }

            public Employee(int empId, string empName, float salary)
            {
                EmpId = empId;
                EmpName = empName;
                Salary = salary;
            }
            public virtual void Display()
            {
                Console.WriteLine($"Employee ID: {EmpId}");
                Console.WriteLine($"Employee Name: {EmpName}");
                Console.WriteLine($"Salary: {Salary}");
            }
        }

        public class ParttimeEmployee : Employee
        {
            public float Wages { get; set; }
            public ParttimeEmployee(int empId, string empName, float salary, float wages)
                : base(empId, empName, salary)
            {
                Wages = wages;
            }
            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Wages: {Wages}");
            }
        }

        public interface IStudent
        {
            int StudentId { get; set; }
            string Name { get; set; }
            void ShowDetails();
        }

        public class Dayscholar : IStudent
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public void ShowDetails()
            {
                Console.WriteLine($"Day Scholar Details:");
                Console.WriteLine($"Student ID: {StudentId}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine("Type: Day Scholar");
            }
        }

        public class Resident : IStudent
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public void ShowDetails()
            {
                Console.WriteLine($"Resident Details:");
                Console.WriteLine($"Student ID: {StudentId}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine("Type: Resident");
            }
        }

        class Program1
        {
            static void Main()
            {
                while (true)
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Manage Books");
                    Console.WriteLine("2. Manage Boxes");
                    Console.WriteLine("3. Manage Employees");
                    Console.WriteLine("4. Manage Students");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");

                    int choice;
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            ManageBooks();
                            break;
                        case 2:
                            ManageBoxes();
                            break;
                        case 3:
                            ManageEmployees();
                            break;
                        case 4:
                            ManageStudents();
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }

                    Console.WriteLine();
                }
            }

            static void ManageBooks()
            {
                BookShelf shelf = new BookShelf();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Enter details for Book {i + 1}:");
                    Console.Write("Book Name: ");
                    string bookName = Console.ReadLine();
                    Console.Write("Author Name: ");
                    string authorName = Console.ReadLine();
                    shelf[i] = new Books(bookName, authorName);
                }

                Console.WriteLine();
                shelf.DisplayBooks();
            }

            static void ManageBoxes()
            {
                Console.WriteLine("Enter dimensions for Box 1:");
                Console.Write("Length: ");
                double length1 = double.Parse(Console.ReadLine());
                Console.Write("Breadth: ");
                double breadth1 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter dimensions for Box 2:");
                Console.Write("Length: ");
                double length2 = double.Parse(Console.ReadLine());
                Console.Write("Breadth: ");
                double breadth2 = double.Parse(Console.ReadLine());

                Box box1 = new Box(length1, breadth1);
                Box box2 = new Box(length2, breadth2);
                Box box3 = Box.AddBoxes(box1, box2);

                Console.WriteLine("\nBox 1:");
                box1.Display();
                Console.WriteLine("\nBox 2:");
                box2.Display();
                Console.WriteLine("\nBox 3 (Sum of Box 1 and Box 2):");
                box3.Display();
            }

            static void ManageEmployees()
            {
                Console.WriteLine("Enter details for Full-time Employee:");
                Console.Write("Employee ID: ");
                int empId = int.Parse(Console.ReadLine());
                Console.Write("Employee Name: ");
                string empName = Console.ReadLine();
                Console.Write("Salary: ");
                float salary = float.Parse(Console.ReadLine());

                Employee fullTimeEmployee = new Employee(empId, empName, salary);

                Console.WriteLine("\nEnter details for Part-time Employee:");
                Console.Write("Employee ID: ");
                empId = int.Parse(Console.ReadLine());
                Console.Write("Employee Name: ");
                empName = Console.ReadLine();
                Console.Write("Salary: ");
                salary = float.Parse(Console.ReadLine());
                Console.Write("Wages: ");
                float wages = float.Parse(Console.ReadLine());

                ParttimeEmployee partTimeEmployee = new ParttimeEmployee(empId, empName, salary, wages);

                Console.WriteLine("\nFull-time Employee Details:");
                fullTimeEmployee.Display();

                Console.WriteLine("\nPart-time Employee Details:");
                partTimeEmployee.Display();
            }

            static void ManageStudents()
            {
                Dayscholar dayScholar = new Dayscholar();
                Console.WriteLine("Enter details for Day Scholar:");
                Console.Write("Student ID: ");
                dayScholar.StudentId = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                dayScholar.Name = Console.ReadLine();

                Resident resident = new Resident();
                Console.WriteLine("\nEnter details for Resident:");
                Console.Write("Student ID: ");
                resident.StudentId = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                resident.Name = Console.ReadLine();

                Console.WriteLine();
                dayScholar.ShowDetails();
                Console.WriteLine();
                resident.ShowDetails();
            }
        }
    }
}
