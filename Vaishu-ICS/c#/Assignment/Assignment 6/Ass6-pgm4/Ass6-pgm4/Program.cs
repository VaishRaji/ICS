using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelconcession;

namespace Ass6_pgm4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid age input.");
                return;
            }
            TicketBooking booking = new TicketBooking
            {
                Name = name,
                Age = age
            };

            string concessionMessage = booking.CalculateConcession();
            Console.WriteLine(concessionMessage);

            Console.ReadKey();
        }
    }
}
   
