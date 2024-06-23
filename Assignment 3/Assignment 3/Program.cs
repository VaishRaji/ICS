using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        public class Accounts
        {

            private int AccountNo;
            private string CustomerName;
            private string AccountType;
            private char TransactionType;
            private double Amount;
            private double Balance;


            public Accounts(int AccountNo, string CustomerName, string AccountType)
            {
                this.AccountNo = AccountNo;
                this.CustomerName = CustomerName;
                this.AccountType = AccountType;
                this.Balance = 0;
            }


            public void UpdateBalance(char TransactionType, double Amount)
            {
                this.TransactionType = TransactionType;
                this.Amount = Amount;

                if (TransactionType == 'D')
                {
                    Credit(Amount);
                }
                else if (TransactionType == 'W')
                {
                    Debit(Amount);
                }
                else
                {
                    Console.WriteLine("Invalid transaction type. Please enter 'D' for Deposit or 'W' for Withdrawal.");
                }
            }


            private void Credit(double Amount)
            {
                Balance += Amount;
                Console.WriteLine($"${Amount} deposited successfully.");
                ShowData();
            }


            private void Debit(double Amount)
            {
                if (Amount > Balance)
                {
                    Console.WriteLine("Insufficient balance. Withdrawal failed.");
                }
                else
                {
                    Balance -= Amount;
                    Console.WriteLine($"${Amount} withdrawn successfully.");
                    ShowData();
                }
            }


            public void ShowData()
            {
                Console.WriteLine($"Account Number: {AccountNo}");
                Console.WriteLine($"Customer Name: {CustomerName}");
                Console.WriteLine($"Account Type: {AccountType}");
                Console.WriteLine($"Current Balance: ${Balance}");
                Console.WriteLine();
            }
        }

        public class Student
        {
            private int rollNo;
            private string name;
            private string className;
            private string semester;
            private string branch;
            private int[] marks = new int[5];


            public Student(int rollNo, string name, string className, string semester, string branch)
            {
                this.rollNo = rollNo;
                this.name = name;
                this.className = className;
                this.semester = semester;
                this.branch = branch;
            }


            public void GetMarks()
            {
                Console.WriteLine($"Enter marks for {name} (Roll No: {rollNo}):");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Enter marks for Subject {i + 1}: ");
                    marks[i] = Convert.ToInt32(Console.ReadLine());
                }
            }


            public void DisplayResult()
            {
                int sum = 0;
                foreach (int mark in marks)
                {
                    sum += mark;
                }

                double average = (double)sum / 5;
                Console.WriteLine($"Average Marks: {average}");

                bool failed = false;
                foreach (int mark in marks)
                {
                    if (mark < 35)
                    {
                        failed = true;
                        break;
                    }
                }

                if (failed || average < 50)
                {
                    Console.WriteLine("Result: Failed");
                }
                else
                {
                    Console.WriteLine("Result: Passed");
                }
            }


            public void DisplayData()
            {
                Console.WriteLine($"Roll No: {rollNo}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Class: {className}");
                Console.WriteLine($"Semester: {semester}");
                Console.WriteLine($"Branch: {branch}");
                Console.WriteLine("Marks:");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Subject {i + 1}: {marks[i]}");
                }
            }
        }

        public class SaleDetails
        {
            public int SalesNo;
            public int ProductNo;
            public decimal Price;
            public DateTime DateOfSale;
            public int Qty;
            public decimal TotalAmount;

            public SaleDetails(int salesNo, int productNo, decimal price, DateTime dateOfSale, int qty)
            {
                SalesNo = salesNo;
                ProductNo = productNo;
                Price = price;
                DateOfSale = dateOfSale;
                Qty = qty;
                Sales();
            }

            private void Sales()
            {
                TotalAmount = Price * Qty;
            }

            public void ShowData()
            {
                Console.WriteLine($"Sales Number: {SalesNo}");
                Console.WriteLine($"Product Number: {ProductNo}");
                Console.WriteLine($"Price per unit: {Price:C}");
                Console.WriteLine($"Date of Sale: {DateOfSale.ToShortDateString()}");
                Console.WriteLine($"Quantity sold: {Qty}");
                Console.WriteLine($"Total Amount: {TotalAmount:C}");
            }
        }

        public class Customer
        {
            public int Customerid;
            public string Name;
            public int Age;
            public long Phone;
            public string City;

            public Customer()
            {
                Console.WriteLine("---Default Constructor without Arguments-----");
            }

            public Customer(int custid, string name, int age, long phone, string city)
            {
                Customerid = custid;
                Name = name;
                Age = age;
                Phone = phone;
                City = city;
                Console.WriteLine("---Parameterized Constructor with all Arguments---");
            }

            public static void DisplayCustomer(Customer customer)
            {
                Console.WriteLine($"Customer ID: {customer.Customerid}");
                Console.WriteLine($"Customer Name: {customer.Name}");
                Console.WriteLine($"Age of Customer: {customer.Age}");
                Console.WriteLine($"Phone number: {customer.Phone}");
                Console.WriteLine($"City: {customer.City}");
            }

            ~Customer()
            {
                Console.WriteLine($"Destructor called for customer {Name}");
            }
        }

        public class CombinedProgram
        {
            public static void Main()
            {
                Console.WriteLine("Welcome to the Combined Program!");

                while (true)
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Accounts Details");
                    Console.WriteLine("2. Student Details");
                    Console.WriteLine("3. Sale Details");
                    Console.WriteLine("4. Customer Details");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ManageAccounts();
                            break;
                        case 2:
                            ManageStudents();
                            break;
                        case 3:
                            ManageSaleDetails();
                            break;
                        case 4:
                            ManageCustomerDetails();
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                            break;
                    }
                }
            }

            // Method to manage accounts
            private static void ManageAccounts()
            {
                Console.WriteLine("\nAccounts Details:");

                Console.WriteLine("Enter Account Number:");
                int accountNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Customer Name:");
                string customerName = Console.ReadLine();

                Console.WriteLine("Enter Account Type:");
                string accountType = Console.ReadLine();

                Accounts account = new Accounts(accountNumber, customerName, accountType);

                while (true)
                {
                    Console.WriteLine("\n1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Show Account Details");
                    Console.WriteLine("4. Back to Main Menu");

                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter amount to deposit:");
                            double depositAmount = double.Parse(Console.ReadLine());
                            account.UpdateBalance('D', depositAmount);
                            break;
                        case 2:
                            Console.WriteLine("Enter amount to withdraw:");
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            account.UpdateBalance('W', withdrawAmount);
                            break;
                        case 3:
                            account.ShowData();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                            break;
                    }
                }
            }


            private static void ManageStudents()
            {
                Console.WriteLine("\nStudent Deatils:");

                Console.WriteLine("Enter Student Roll No:");
                int rollNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Class Name:");
                string className = Console.ReadLine();

                Console.WriteLine("Enter Semester:");
                string semester = Console.ReadLine();

                Console.WriteLine("Enter Branch:");
                string branch = Console.ReadLine();

                Student student = new Student(rollNo, name, className, semester, branch);

                student.GetMarks();
                Console.WriteLine("\nStudent Details:");
                student.DisplayData();
                Console.WriteLine("\nResult:");
                student.DisplayResult();
            }


            private static void ManageSaleDetails()
            {
                Console.WriteLine("\nSale Details:");

                Console.WriteLine("Enter Sales Number:");
                int salesNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product Number:");
                int productNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Price per unit:");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Quantity sold:");
                int qty = int.Parse(Console.ReadLine());

                SaleDetails sale = new SaleDetails(salesNo, productNo, price, DateTime.Today, qty);

                Console.WriteLine("\nSales Details:");
                sale.ShowData();
            }


            private static void ManageCustomerDetails()
            {
                Console.WriteLine("\nCustomer Details:");

                Console.WriteLine("Enter Customer ID:");
                int customerId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Customer Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Age:");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Phone Number:");
                long phone = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter City:");
                string city = Console.ReadLine();

                Customer customer = new Customer(customerId, name, age, phone, city);

                Console.WriteLine("\nCustomer Details:");
                Customer.DisplayCustomer(customer);
            }
        }
    }
}

   
