using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass6_pgm3
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
    }

    public class Program
    {
        private static List<Employee> employees = new List<Employee>();

        public static void Main(string[] args)
        {
            PopulateData();
            Console.WriteLine("Welcome to Employee Management Program");

            bool exit = false;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Display all employees");
                Console.WriteLine("2. Display employees with salary greater than a specific amount");
                Console.WriteLine("3. Display employees who belong to a specific city");
                Console.WriteLine("4. Display employees sorted by name (ascending)");
                Console.WriteLine("5. Exit");

                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayAllEmployees();
                        break;
                    case "2":
                        DisplayEmployeesAboveSalary();
                        break;
                    case "3":
                        DisplayEmployeesByCity();
                        break;
                    case "4":
                        DisplayEmployeesSortedByName();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                        break;
                }

            } while (!exit);
        }

        private static void PopulateData()
        {
            employees.Add(new Employee { EmpId = 1, EmpName = "Vaishnavi", EmpCity = "Chennai", EmpSalary = 50000 });
            employees.Add(new Employee { EmpId = 2, EmpName = "Saajana", EmpCity = "Mumbai", EmpSalary = 48000 });
            employees.Add(new Employee { EmpId = 3, EmpName = "Kajal", EmpCity = "Bangalore", EmpSalary = 42000 });
            employees.Add(new Employee { EmpId = 4, EmpName = "Latha", EmpCity = "Delhi", EmpSalary = 46000 });
            employees.Add(new Employee { EmpId = 5, EmpName = "Swapna", EmpCity = "Chennai", EmpSalary = 44000 });
        }

        private static void DisplayAllEmployees()
        {
            Console.WriteLine("\nAll Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
            }
            WaitForUserInput();
        }

        private static void DisplayEmployeesAboveSalary()
        {
            Console.Write("Enter the minimum salary: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal minSalary))
            {
                var result = employees.Where(emp => emp.EmpSalary >= minSalary).ToList();
                if (result.Any())
                {
                    Console.WriteLine($"\nEmployees with salary greater than or equal to {minSalary}:");
                    foreach (var emp in result)
                    {
                        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
                    }
                }
                else
                {
                    Console.WriteLine($"No employees found with salary greater than or equal to {minSalary}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for salary.");
            }
            WaitForUserInput();
        }

        private static void DisplayEmployeesByCity()
        {
            Console.Write("Enter the city name: ");
            string cityName = Console.ReadLine();
            var result = employees.Where(emp => emp.EmpCity.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
            if (result.Any())
            {
                Console.WriteLine($"\nEmployees belonging to {cityName}:");
                foreach (var emp in result)
                {
                    Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
                }
            }
            else
            {
                Console.WriteLine($"No employees found belonging to {cityName}");
            }
            WaitForUserInput();
        }

        private static void DisplayEmployeesSortedByName()
        {
            List<Employee> sortedEmployees = employees.OrderBy(emp => emp.EmpName).ToList();
            Console.WriteLine("\nEmployees sorted by Name (Ascending):");
            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
            }
            WaitForUserInput();
        }

        private static void WaitForUserInput()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

