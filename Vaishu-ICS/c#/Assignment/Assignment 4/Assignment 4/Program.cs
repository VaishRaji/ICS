using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        public class NameProcessor
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public NameProcessor(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public void Display()
            {
                Console.WriteLine(FirstName.ToUpper());
                Console.WriteLine(LastName.ToUpper());
            }
        }

        public class LetterCount
        {
            public static int CountOccurrences(string input, char letter)
            {
                int count = 0;
                foreach (char c in input)
                {
                    if (char.ToUpper(c) == char.ToUpper(letter))
                    {
                        count++;
                    }
                }
                return count;
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
                    Console.WriteLine("2. Scholarship Calculator");
                    Console.WriteLine("3. Doctor Details");
                    Console.WriteLine("4. Display Name in Uppercase");
                    Console.WriteLine("5. Count Letter Occurrences");
                    Console.WriteLine("6. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ManageAccounts();
                            break;
                        case 2:
                            ManageScholarship();
                            break;
                        case 3:
                            ManageDoctorDetails();
                            break;
                        case 4:
                            DisplayNameInUppercase();
                            break;
                        case 5:
                            CountLetterOccurrences();
                            break;
                        case 6:
                            Console.WriteLine("Exiting the program...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                            break;
                    }
                }
            }

            private static void ManageAccounts()
            {
                Console.WriteLine("\nAccounts Details:");

                try
                {
                    Console.WriteLine("Enter Account Number:");
                    int accountNo = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Customer Name:");
                    string customerName = Console.ReadLine();

                    Console.WriteLine("Enter Account Type:");
                    string accountType = Console.ReadLine();

                    Accounts account = new Accounts(accountNo, customerName, accountType);

                    Console.WriteLine("\nEnter amount to deposit:");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);

                    Console.WriteLine("\nEnter amount to withdraw:");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAmount);


                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}. Please enter a valid number.");
                }
                catch (InsufficientBalanceException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Argument Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("\nProgram execution completed. Press Enter to continue.");
                    Console.ReadLine();
                }
            }

            private static void ManageScholarship()
            {
                Console.WriteLine("\nScholarship Calculator:");

                try
                {
                    Scholarship scholarship = new Scholarship();

                    Console.WriteLine("Enter marks (0-100):");
                    int marks = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter fees:");
                    double fees = double.Parse(Console.ReadLine());

                    double scholarshipAmount = scholarship.Merit(marks, fees);

                    Console.WriteLine($"Scholarship amount for marks {marks} and fees ${fees} is ${scholarshipAmount}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}. Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.ReadLine();
            }


            private static void ManageDoctorDetails()
            {
                Console.WriteLine("\nDoctor Details:");

                try
                {
                    Console.WriteLine("Select a doctor:");
                    Console.WriteLine("1. Dr. Raji (RegnNo: 27063, Fees: $1000)");
                    Console.WriteLine("2. Dr. Banu (RegnNo: 03021, Fees: $1500)");
                    Console.Write("Enter your choice (1 or 2): ");
                    int choice = int.Parse(Console.ReadLine());

                    Doctor selectedDoctor = null;
                    switch (choice)
                    {
                        case 1:
                            selectedDoctor = new Doctor(12345, "Dr. Raji", 1000.0);
                            break;
                        case 2:
                            selectedDoctor = new Doctor(54321, "Dr. Banu", 1500.0);
                            break;
                        default:
                            throw new ArgumentException("Invalid choice. Please enter 1 or 2.");
                    }


                    Console.WriteLine("Selected Doctor:");
                    selectedDoctor.DisplayDoctorInfo();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}. Please enter a valid number.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.ReadLine();
            }


            private static void DisplayNameInUppercase()
            {
                Console.WriteLine("\nDisplay Name in Uppercase:");

                try
                {
                    string firstName = "Vaishu";
                    string lastName = "Raji";

                    NameProcessor processor = new NameProcessor(firstName, lastName);
                    processor.Display();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.ReadLine();
            }


            private static void CountLetterOccurrences()
            {
                Console.WriteLine("\nCount Letter Occurrences:");

                try
                {
                    Console.WriteLine("Enter a string:");
                    string inputString = Console.ReadLine();

                    Console.WriteLine("Enter the letter to count:");
                    char letterToCount = Console.ReadKey().KeyChar; // Read the first character entered

                    int occurrences = LetterCount.CountOccurrences(inputString, letterToCount);

                    Console.WriteLine($"\nThe letter '{letterToCount}' appears {occurrences} times in the string '{inputString}'.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.ReadLine();
            }
        }

        public class Accounts
        {
            private int AccountNo;
            private string CustomerName;
            private string AccountType;
            private double Balance;

            public Accounts(int accountNo, string customerName, string accountType)
            {
                AccountNo = accountNo;
                CustomerName = customerName;
                AccountType = accountType;
                Balance = 0;
            }

            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be greater than zero.");
                }

                Balance += amount;
                Console.WriteLine($"${amount} deposited successfully.");
                ShowData();
            }

            public void Withdraw(double amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be greater than zero.");
                }

                if (amount > Balance)
                {
                    throw new InsufficientBalanceException("Insufficient balance. Withdrawal failed.");
                }

                Balance -= amount;
                Console.WriteLine($"${amount} withdrawn successfully.");
                ShowData();
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

        public class Scholarship
        {
            public double Merit(int marks, double fees)
            {
                double scholarshipAmount = 0;

                if (marks >= 90 && marks <= 100)
                {
                    scholarshipAmount = 0.5 * fees;
                }
                else if (marks >= 80 && marks < 90)
                {
                    scholarshipAmount = 0.3 * fees;
                }
                else if (marks >= 70 && marks < 80)
                {
                    scholarshipAmount = 0.2 * fees;
                }
                else
                {
                    scholarshipAmount = 0;
                }

                return scholarshipAmount;
            }
        }

        public class Doctor
        {
            private int regnNo;
            private string name;
            private double feesCharged;
            public int RegnNo
            {
                get { return regnNo; }
                set { regnNo = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double FeesCharged
            {
                get { return feesCharged; }
                set { feesCharged = value; }
            }


            public Doctor(int regnNo, string name, double feesCharged)
            {
                RegnNo = regnNo;
                Name = name;
                FeesCharged = feesCharged;
            }


            public void DisplayDoctorInfo()
            {
                Console.WriteLine($"Registration Number: {RegnNo}");
                Console.WriteLine($"Doctor's Name: {Name}");
                Console.WriteLine($"Fees Charged: ${FeesCharged}");
            }
        }

        public class InsufficientBalanceException : Exception
        {
            public InsufficientBalanceException()
            {
            }

            public InsufficientBalanceException(string message)
                : base(message)
            {
            }

            public InsufficientBalanceException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
       
    }
}
