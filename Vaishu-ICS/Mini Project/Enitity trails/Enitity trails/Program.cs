using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity_trails
{
    class Program
    {
        static rrsminiEntities db = new rrsminiEntities();
        static Train train = new Train();
        static TicketClassDetail TCD = new TicketClassDetail();

        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t \t  Welcome to ICS Mini Proj-Railway Reservation System ");
            bool exitProgram = false;
            while (!exitProgram)
            {

                Console.WriteLine("\n Press 1  login as Admin");
                Console.WriteLine(" Press 2  login as User");
                Console.WriteLine(" Press 3 exit");
                Console.WriteLine("\n Enter your Choice");
                string Choice = Console.ReadLine();
                switch (Choice)
                {
                    case "1":
                        Console.WriteLine("\n admin");
                        Admincontrol();
                        break;
                    case "2":
                        Console.WriteLine("\n user");
                        UserControl();
                        break;
                    case "3":
                        Console.WriteLine("\nHave a Great day");
                        exitProgram = true;
                        return;
                        break;
                    default:
                        Console.WriteLine("\nEnter valid input");
                        break;
                }
                
            }
        }
        static void Admincontrol()
        {
            Console.WriteLine("Enter Admin ID:");
            int AdminId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Password:");
            string Password = Console.ReadLine();
            var admin = db.Admins.FirstOrDefault(a => a.AdminId == AdminId && a.Password == Password);
            if (admin != null)
            {
                bool logout = false;
                while (!logout)
                {
                    Console.WriteLine("\n Admin login successful!");
                    Console.WriteLine("\n Press 1  Add Trains");
                    Console.WriteLine("\n Press 2  Modify Trains");
                    Console.WriteLine("\n Press 3  Delete Trains");
                    Console.WriteLine("\n Press 4  logout");
                    Console.WriteLine("\n Press 5  MainMenu");
                    Console.WriteLine("\n Enter your Choice");

                    string res = Console.ReadLine();
                    switch (res)
                    {
                        case "1":
                            Console.WriteLine("\n Add The Trains");
                            AddTrain();
                            Console.WriteLine("Trains have been added successfully");
                            displaytrainForAdmin();
                            DisplayAllTicketClassDetailsForAdmin();
                            break;
                        case "2":
                            Console.WriteLine("\n Modify the train");
                            displaytrainForAdmin();
                            Console.WriteLine("\n Train to be modified");
                            ModifyTrain();
                            break;
                        case "3":
                            Console.WriteLine("\n Train to be deleted");
                            DeleteTrain();
                            displaytrainForAdmin();
                            break;
                        case "4":
                            Console.WriteLine("\n Loggedout");
                            logout = true;
                            break;
                        case "5":
                            logout = true;
                            return;
                        default:
                            Console.WriteLine("\n Enter valid number");
                            break;

                    }
                }
            }
            else
                {
                    Console.WriteLine("\n Invalid admin credentials.");
                    Console.ReadLine();

                }
            }
        static void UserControl()
        {
            bool exitUserControl = false;
            while (!exitUserControl)
            {
                Console.WriteLine("\n User login successful! ");
                Console.WriteLine("\n Press 1  Booking Trains");
                Console.WriteLine("\n Press 2  Printing Tickets");
                Console.WriteLine("\n Press 3  Cancel the tickets");
                Console.WriteLine("\n Press 4  Cancellation Ticket Details");
                Console.WriteLine("\n Press 5  Exit");
                Console.WriteLine("\n Press 6  MainMenu");
                Console.WriteLine("\n Enter your Choice");


                string res = Console.ReadLine();
                switch (res)
                {
                    case "1":
                        Console.WriteLine("\n Ticket Booking");
                        displaytrainForUser();
                        DisplayAllTicketClassDetailsForUser();
                        BookingTicket();
                        DisplayAllBooking_Details();

                        break;
                    case "2":
                        Console.WriteLine("\n Booked Tickets");
                        DisplayBooking_Details();
                        Console.WriteLine("\n Ticket Booked Details");
                        break;
                    case "3":
                        Console.WriteLine("\n Ticket Cancellation");
                        Cancel_Ticket();
                        DisplayAllCanceltDetails();
                        break;
                    case "4":
                        DisplayCancellationDetails();
                        Console.WriteLine("\n Details of Cancelled Tickets");
                        break;
                    case "5":
                        Console.WriteLine("\n Happy Journey");
                        exitUserControl = true;
                        break;
                    case "6":
                        exitUserControl = true;
                        return;
                    default:
                        Console.WriteLine("\n Enter valid choice");
                        break;
                }
            }
        }

        static void AddTrain()
        {
            Console.WriteLine("Enter Train Number:");
            train.TrainNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Train Name:");
            train.TrainName = Console.ReadLine();
            Console.WriteLine("Enter Source:");
            train.Source = Console.ReadLine();
            Console.WriteLine("Enter Destination:");
            train.Destination = Console.ReadLine();
            train.Status = "Active";
            db.Trains.Add(train);
            db.SaveChanges();
            var classname = new string[] { "First Class", "Second Class", "Sleeper" };
            foreach (var ClassName in classname)
            {
                TCD.TrainNo = train.TrainNo;
                TCD.ClassName = ClassName;
                Console.WriteLine($"Enter TOTAL SEATS {ClassName}:");
                TCD.TotalSeats = int.Parse(Console.ReadLine());
                Console.WriteLine("Available seats:");
                TCD.AvailableSeats = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Fare Amount");
                TCD.Fare = int.Parse(Console.ReadLine());

                db.TicketClassDetails.Add(TCD);
                db.SaveChanges();
            }
        }

        static void displaytrainForAdmin()
        {
            var allTrains = db.Trains.ToList();

            foreach (var train in allTrains)
            {
                Console.WriteLine($"TrainNo: {train.TrainNo}, TrainName: {train.TrainName}, Source: {train.Source}, Destination: {train.Destination}, Status: {train.Status}");
            }
        }

        static void DisplayAllTicketClassDetailsForAdmin()
        {
            try
            {
                var allTicketClassDetails = db.TicketClassDetails.ToList();


                Console.WriteLine(" \n \t \t Overall Ticket Class Details ");


                Console.WriteLine(" Train No  Class Name  Total Seats  Available Seats  Fare Amount ");

                foreach (var ticketClassDetail in allTicketClassDetails)
                {
                        Console.WriteLine(" {0,-9}  {1,-10}  {2,-11}  {3,-16}  {4,-11} ",
                        ticketClassDetail.TrainNo, ticketClassDetail.ClassName, ticketClassDetail.TotalSeats,
                        ticketClassDetail.AvailableSeats, ticketClassDetail.Fare);
                }

                if (!allTicketClassDetails.Any())
                {
                    Console.WriteLine("\n No ticket class details found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n An error occurred: {ex.Message}");
            }
        }

        static void displaytrainForUser()
        {
            var activeTrains = db.Trains.Where(t => t.Status == "Active").ToList();

            
            Console.WriteLine(" Active Trains ");

            foreach (var train in activeTrains)
            {
                Console.WriteLine($"TrainNo: {train.TrainNo}, TrainName: {train.TrainName}, Source: {train.Source}, Destination: {train.Destination}, Status: {train.Status}");


            }

        }
        static void DisplayAllTicketClassDetailsForUser()
        {
            try
            {
                
                var allTicketClassDetails = from train in db.Trains
                                            join ticketClassDetail in db.TicketClassDetails
                                            on train.TrainNo equals ticketClassDetail.TrainNo
                                            where train.Status == "Active"
                                            select ticketClassDetail;

                if (allTicketClassDetails.Any())
                {

                    Console.WriteLine("\n \t \t  Available Ticket Details");

                    Console.WriteLine(" Train No  Class Name  Total Seats  Available Seats  Fare Amount ");

                    foreach (var ticketClassDetail in allTicketClassDetails)
                    {
                            Console.WriteLine(" {0,-9}  {1,-10}  {2,-11}  {3,-16}  {4,-11} ",
                            ticketClassDetail.TrainNo, ticketClassDetail.ClassName, ticketClassDetail.TotalSeats,
                            ticketClassDetail.AvailableSeats, ticketClassDetail.Fare);
                    }
                }
                else
                {
                    Console.WriteLine("\n No ticket class details found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n An error occurred: {ex.Message}");
            }
        }


        public static void ModifyTrain()
        {
            Console.WriteLine("\n Enter Train Number:");
            int trainNo = int.Parse(Console.ReadLine());

            
            var trainToUpdate = db.Trains.FirstOrDefault(t => t.TrainNo == trainNo);
            if (trainToUpdate != null)
            {
                Console.WriteLine("\n Enter Train Name:");
                trainToUpdate.TrainName = Console.ReadLine();
                Console.WriteLine("\n Enter Train source:");
                trainToUpdate.Source = Console.ReadLine();
                Console.WriteLine("\n Enter Train Destination:");
                trainToUpdate.Destination = Console.ReadLine();
                Console.WriteLine("\n Enter Status:");
                trainToUpdate.Status = Console.ReadLine();
                
                db.SaveChanges();
                Console.WriteLine("\n Train details updated successfully.");
                Console.WriteLine("\n Modified Table");
                displaytrainForAdmin();
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Train with the provided number does not exist.");
                Admincontrol();
            }
        }

        public static void DeleteTrain()
        {
            Console.WriteLine("\n Enter Train Number:");
            int trainNo = int.Parse(Console.ReadLine());

            
            var trainToDelete = db.Trains.FirstOrDefault(t => t.TrainNo == trainNo);
            if (trainToDelete != null)
            {
                
                trainToDelete.Status = "InActive";
                db.SaveChanges();
                Console.WriteLine("\n Deleted successfully.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\n Train number doesnt exists.");

            }
        }

        public static void BookingTicket()
        {
            try
            {
                Console.Write("\n Enter Passenger Name: ");
                string passengerName = Console.ReadLine();

                Console.Write("\n Enter Train Number: ");
                int trainNo = Convert.ToInt32(Console.ReadLine());

               
                var train = db.Trains.FirstOrDefault(t => t.TrainNo == trainNo && t.Status == "Active");
                if (train == null)
                {
                    Console.WriteLine("\n Cannot book tickets for an inactive train.");
                    Console.WriteLine("\n Bookings only for active train,So please enter valid train number:");
                    return; 
                }

                Console.Write("\n Enter Class Name: ");
                string className = Console.ReadLine();

                Console.Write("\n Enter Date of Travel (YYYY-MM-DD): ");
                DateTime dateOfTravel = Convert.ToDateTime(Console.ReadLine());

                Console.Write("\n Enter Number of Tickets: ");
                int numberOfTickets = Convert.ToInt32(Console.ReadLine());

                db.BookTrainTicket(passengerName, trainNo, className, dateOfTravel, numberOfTickets);
                db.SaveChanges();

                Console.WriteLine("\n Ticket booked successfully!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n An error occurred: " + ex.Message);
            }
        }

        static void Cancel_Ticket()
        {
            Console.WriteLine("\n Enter Booking ID:");
            int bookingId = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Enter Passenger Name:");
            string passengerName = Console.ReadLine();

            Console.WriteLine("\n Enter Train Number:");
            int trainNo = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Enter Class Name:");
            string className = Console.ReadLine();

            Console.WriteLine("\n Enter Number of Tickets to Cancel:");
            int numberOfTickets = int.Parse(Console.ReadLine());

            try
            {
                
                db.CancelTicket(bookingId, passengerName, trainNo, className, numberOfTickets);
                db.SaveChanges();
                Console.WriteLine("\n Cancellation successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void DisplayBooking_Details()
        {
            Console.WriteLine("\nEnter Booking ID:");
            int bookingId = int.Parse(Console.ReadLine());

            var booking = db.Bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking != null)
            {
                Console.WriteLine("\n BOOKING DETAILS");
                Console.WriteLine($" Booking ID:       {booking.BookingId}");
                Console.WriteLine($" Passenger Name:   {booking.PassengerName}");
                Console.WriteLine($" Train Number:     {booking.TrainNo}");
                Console.WriteLine($" Class Name:       {booking.ClassName}");
                Console.WriteLine($" Date of Travel:   {booking.DateOfTravel}");
                Console.WriteLine($" Number of Tickets:{booking.NumberOfTickets}");
                Console.WriteLine($" Total Amount:     {booking.TotalAmount}");
                Console.WriteLine($" Status:           {booking.Status}");
            }
            else
            {
                Console.WriteLine("\n Booking not found.");
            }
        }
        static void DisplayAllBooking_Details()
        {
            try
            {
                Console.WriteLine("\n Booking Details ");

                Console.WriteLine(" Booking ID  Train ID  Passenger Name  Class Name  Total Tickets  Booking Status  Book Amount ");

                foreach (var book in db.Bookings)
                {
                        Console.WriteLine("\n {0,-10}  {1,-8} {2,-10}  {3,-12}  {4,-14}  {5,-15}  {6,-14} ",
                        book.BookingId, book.TrainNo, book.PassengerName, book.ClassName,
                        book.NumberOfTickets, book.Status, book.TotalAmount);
                }

                if (!db.Bookings.Any())
                {
                    Console.WriteLine("\n No bookings found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        static void DisplayCancellationDetails()
        {
            try
            {
                Console.WriteLine("\n Enter Booking ID:");
                int bookingId = int.Parse(Console.ReadLine());

                var cancellation = db.Cancellations.FirstOrDefault(c => c.BookingId == bookingId);
                if (cancellation != null)
                {
                    Console.WriteLine("\n \t \t CANCELLATION DETAILS");
                    Console.WriteLine($" Booking ID:       {cancellation.BookingId}");
                    Console.WriteLine($"Passenger Name:    {cancellation.PassengerName}");
                    Console.WriteLine($"Train Number:      {cancellation.TrainNo}");
                    Console.WriteLine($"Class Name:        {cancellation.ClassName}");
                    Console.WriteLine($" Number of Tickets: {cancellation.NumberOfTickets}");
                }
                else
                {
                    Console.WriteLine("\n Cancellation details not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        static void DisplayAllCanceltDetails()
        {
            try
            {
                Console.WriteLine(" \n \t \t Details of Cancelled Tickets ");

                Console.WriteLine("\n Cancel ID      Date of Cancel    Train ID  No. of Tickets   Booking ID ");

                foreach (var cancel in db.Cancellations)
                {
                        Console.WriteLine(" {0,-9}  {1,-15}  {2,-8}  {3,-14}  {4,-11} ",
                        cancel.CancellationId, cancel.DateOfCancel, cancel.TrainNo,
                        cancel.NumberOfTickets, cancel.BookingId);
                }

                if (!db.Cancellations.Any())
                {
                    Console.WriteLine("\n No cancelled tickets found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n An error occurred: {ex.Message}");
            }
        }

    }
}


