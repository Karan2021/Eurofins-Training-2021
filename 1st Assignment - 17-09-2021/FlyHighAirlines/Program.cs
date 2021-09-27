using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO FLYHIGH AIRLINES");
            Console.WriteLine("---------------------------\n");

            BookTickets book = new BookTickets();

            string type = book.askType();
            book.Type = type;

            string source = book.askSource();
            book.Source = source;

            //string sourceCheck = book.askSource();
            string destination = book.askDestination();
            book.Destination = destination;

            string departureDate = book.askDepartureDate();
            book.DepartureDate = departureDate;

            string returnDate = book.askReturnDate();
            book.ReturnDate = returnDate;

            string flightClass = book.askFlightClass();
            book.FlightClass = flightClass;

            Console.WriteLine("\nFlight Available\n");

            Console.WriteLine("Enter Weight of your Luggage");
            int weightOfLuggageInput = Convert.ToInt32(Console.ReadLine());
            double weightOfLuggage = CheckLuggageWeight.checkLuggageWeight(flightClass, weightOfLuggageInput); ;
            book.WeightOfLuggage = weightOfLuggage;

            Console.WriteLine("\nEnter ID Number to confirm Booking");
            string id = Console.ReadLine();

            Console.WriteLine("\n********HAPPY JOURNEY********");

            Console.WriteLine();

            Console.Read();
        }
    }
}
