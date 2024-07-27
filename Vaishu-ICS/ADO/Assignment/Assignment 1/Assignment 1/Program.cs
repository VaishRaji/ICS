using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
        };

            // 1. Display a list of all the employee who have joined before 1/1/2015

            var employeesJoinedBefore2015 = employees.Where(e => e.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("(1)Employees who joined before 1/1/2015:");
            foreach (var emp in employeesJoinedBefore2015)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, DOJ: {emp.DOJ.ToShortDateString()}");
            }

            // 2. Display a list of all the employee whose date of birth is after 1/1/1990

            var employeesDOBAfter1990 = employees.Where(e => e.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("\n(2)Employees whose DOB is after 1/1/1990:");
            foreach (var emp in employeesDOBAfter1990)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, DOB: {emp.DOB.ToShortDateString()}");
            }

            //3.Display a list of all the employee whose designation is Consultant and Associate

           var employeesConsultantOrAssociate = employees.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            Console.WriteLine("\n(3)Employees with designation Consultant or Associate:");
            foreach (var emp in employeesConsultantOrAssociate)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, Title: {emp.Title}");
            }

            // 4. Display total number of employees
            var totalEmployees = employees.Count();
            Console.WriteLine($"\n(4)Total number of employees: {totalEmployees}");

            // 5. Display total number of employees belonging to “Chennai”
            var totalEmployeesInChennai = employees.Count(e => e.City == "Chennai");
            Console.WriteLine($"\n(5)Total number of employees in Chennai: {totalEmployeesInChennai}");

            // 6. Display highest employee id from the list
            var highestEmployeeId = employees.Max(e => e.EmployeeID);
            Console.WriteLine($"\n(6)Highest Employee ID: {highestEmployeeId}");

            // 7. Display total number of employees who have joined after 1/1/2015
            var totalEmployeesJoinedAfter2015 = employees.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"\n(7)Total number of employees who joined after 1/1/2015: {totalEmployeesJoinedAfter2015}");

            // 8. Display total number of employees whose designation is not “Associate”
            var totalEmployeesNotAssociate = employees.Count(e => e.Title != "Associate");
            Console.WriteLine($"\n(8)Total number of employees whose designation is not Associate: {totalEmployeesNotAssociate}");

            // 9. Display total number of employees based on City
            var totalEmployeesByCity = employees.GroupBy(e => e.City).Select(g => new { City = g.Key, Count = g.Count() });
            Console.WriteLine("\n(9)Total number of employees by City:");
            foreach (var cityGroup in totalEmployeesByCity)
            {
                Console.WriteLine($"{cityGroup.City}: {cityGroup.Count}");
            }

            // 10. Display total number of employees based on city and title
            var totalEmployeesByCityAndTitle = employees.GroupBy(e => new { e.City, e.Title })
                                                         .Select(g => new { City = g.Key.City, Title = g.Key.Title, Count = g.Count() });
            Console.WriteLine("\n(10)Total number of employees by City and Title:");
            foreach (var cityTitleGroup in totalEmployeesByCityAndTitle)
            {
                Console.WriteLine($"{cityTitleGroup.City} - {cityTitleGroup.Title}: {cityTitleGroup.Count}");
            }

            // 11. Display total number of employees who is youngest in the list
            var youngestEmployee = employees.OrderByDescending(e => e.DOB).FirstOrDefault();
            Console.WriteLine($"\n(11)Youngest employee: {youngestEmployee?.FirstName} {youngestEmployee?.LastName}, DOB: {youngestEmployee?.DOB.ToShortDateString()}");

            Console.ReadLine(); // Keep the console open
        }
    }

}
    

