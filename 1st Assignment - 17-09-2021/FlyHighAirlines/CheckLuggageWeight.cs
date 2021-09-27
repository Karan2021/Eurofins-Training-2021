using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class CheckLuggageWeight
    {
        public static double checkLuggageWeight(string flightClass, int w)
        {
            int n;
            List<string> flightClassList = new List<string> { "Economy class", "Premium class", "Business class" };
            if (flightClass == "Economy class")
                n = 3;
            else if (flightClass == "Premium class")
                n = 1;
            else
                n = 2;

            int FirstW = 50;
            int BusinessW = 40;
            int EconomyW = 20;

            if (n == 1)
            {
                if (w <= FirstW)
                {
                    Console.WriteLine("You are Good to go...");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Your Luggage weight exceeds maximum limit.");
                    Console.WriteLine("You need to Pay " + (2 * (w - FirstW)) + "$ more.");
                    return (2 * (w - FirstW));
                }
            }
            else if (n == 2)
            {
                if (w <= BusinessW)
                {
                    Console.WriteLine("You are Good to go...");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Your Luggage weight exceeds maximum limit.");
                    Console.WriteLine("You need to Pay " + (2 * (w - BusinessW)) + "$ more.");
                    return (2 * (w - BusinessW));
                }
            }
            else if (n == 3)
            {
                if (w <= EconomyW)
                {
                    Console.WriteLine("You are Good to go...");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Your Luggage weight exceeds maximum limit.");
                    Console.WriteLine("You need to Pay " + (2 * (w - EconomyW)) + "$ more.");
                    return (2 * (w - EconomyW));
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice..");
                return 0;
            }
        }
    }
}
