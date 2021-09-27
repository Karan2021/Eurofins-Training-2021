using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class BookTickets
    {
        private string type, source, destination, departureDate, returnDate, flightClass;
        double weightOfLuggage;

        public string Type { get => type; set => type = value; }
        public string Source { get => source; set => source = value; }
        public string Destination { get => destination; set => destination = value; }
        public string DepartureDate { get => departureDate; set => departureDate = value; }
        public string ReturnDate { get => returnDate; set => returnDate = value; }
        public string FlightClass { get => flightClass; set => flightClass = value; }
        public double WeightOfLuggage { get => weightOfLuggage; set => weightOfLuggage = value; }

        public string askType()
        {
            Console.WriteLine("Select the Type of Trip");
            List<string> typeList = new List<string> { "One Way", "Round Trip" };
            Console.WriteLine("1.One Way | 2.Round Trip");
            int type = Convert.ToInt32(Console.ReadLine());
            return typeList[type - 1];
        }

        public string askSource()
        {
            Console.WriteLine("Select Source\n1.Bangalore\n2.Mumbai\n3.Pune\n4.Delhi");
            List<string> sourceList = new List<string> { "Bangalore", "Mumbai", "Pune", "Delhi" };
            int source = Convert.ToInt32(Console.ReadLine());
            return sourceList[source - 1];
        }

        public string askDestination()
        {
            Console.WriteLine("Select Destination\n1.Bangalore\n2.Mumbai\n3.Pune\n4.Delhi");
            List<string> destinationList = new List<string> { "Bangalore", "Mumbai", "Pune", "Delhi" };
            int destination = Convert.ToInt32(Console.ReadLine());
            string destinationCheck = destinationList[destination - 1];
            return destinationList[destination - 1];

        }

        public string askDepartureDate()
        {
            Console.WriteLine("Select Departure Date - dd/mm/yyyy");
            string departureDate = Console.ReadLine();
            return departureDate;
        }

        public string askReturnDate()
        {
            Console.WriteLine("Select Return Date - dd/mm/yyyy - Enter 0 if One Way Trip");
            string returnDate = Console.ReadLine();
            return returnDate;
        }

        public string askFlightClass()
        {
            List<string> flightClassList = new List<string> { "Economy class", "Premium class", "Business class" };
            Console.WriteLine("Choose class\n1.Economy class\n2.Premium class\n3.Business class");
            int flightClass = Convert.ToInt32(Console.ReadLine());
            return flightClassList[flightClass - 1];
        }

        
    }
}
