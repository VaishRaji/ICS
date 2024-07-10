using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_4_pgm_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee
            {
                EmployeeID = 1001,
                FirstName = "Malcolm",
                LastName = "Daruwalla",
                Title = "Manager",
                DOB = new DateTime(1984, 11, 16),
                DOJ = new DateTime(2011, 6, 8),
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1002,
                FirstName = "Asdin",
                LastName = "Dhalla",
                Title = "AsstManager",
                DOB = new DateTime(1984, 8, 20),
                DOJ = new DateTime(2012, 7, 7),
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1003,
                FirstName = "Madhavi",
                LastName = "Oza",
                Title = "Consultant",
                DOB = new DateTime(1987, 11, 14),
                DOJ = new DateTime(2015, 4, 12),
                City = "Pune"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1004,
                FirstName = "Saba",
                LastName = "Shaikh",
                Title = "SE",
                DOB = new DateTime(1990, 6, 3),
                DOJ = new DateTime(2016, 2, 2),
                City = "Pune"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1005,
                FirstName = "Nazia",
                LastName = "Shaikh",
                Title = "SE",
                DOB = new DateTime(1991, 3, 8),
                DOJ = new DateTime(2016, 2, 2),
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1006,
                FirstName = "Amit",
                LastName = "Pathak",
                Title = "Consultant",
                DOB = new DateTime(1989, 11, 7),
                DOJ = new DateTime(2014, 8, 8),
                City = "Chennai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1007,
                FirstName = "Vijay",
                LastName = "Natrajan",
                Title = "Consultant",
                DOB = new DateTime(1989, 12, 2),
                DOJ = new DateTime(2015, 6, 1),
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1008,
                FirstName = "Rahul",
                LastName = "Dubey",
                Title = "Associate",
                DOB = new DateTime(1993, 11, 11),
                DOJ = new DateTime(2014, 11, 6),
                City = "Chennai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1009,
                FirstName = "Suresh",
                LastName = "Mistry",
                Title = "Associate",
                DOB = new DateTime(1992, 8, 12),
                DOJ = new DateTime(2014, 12, 3),
                City = "Chennai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1010,
                FirstName = "Sumit",
                LastName = "Shah",
                Title = "Manager",
                DOB = new DateTime(1991, 4, 12),
                DOJ = new DateTime(2016, 1, 2),
                City = "Pune"
            });

            Console.WriteLine("All Employees:");
            DisplayEmployees(empList);

            Console.WriteLine("\nEmployees whose location is not Mumbai:");
            var notInMumbai = empList.Where(e => e.City != "Mumbai");
            DisplayEmployees(notInMumbai);

            Console.WriteLine("\nEmployees whose title is AsstManager:");
            var asstManagers = empList.Where(e => e.Title == "AsstManager");
            DisplayEmployees(asstManagers);

            Console.WriteLine("\nEmployees whose Last Name starts with 'S':");
            var startsWithS = empList.Where(e => e.LastName.StartsWith("S"));
            DisplayEmployees(startsWithS);

            Console.ReadKey();
        }

        static void DisplayEmployees(IEnumerable<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
        }
    }

    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
}
        
        
