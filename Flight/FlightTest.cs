using System;
using System.Collections.Generic;
using System.Text;

namespace Flight
{
    public class FlightTest : FlightClass
    {
        public FlightTest(string v1, string v2, City o, City d) : base(v1, v2, o, d)
        {
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Airline Name: ");
            airLineName = Convert.ToString(Console.ReadLine());
            City o = new City("Louisville, KY", 38.2527, 85.7585);
            originCity = o;
            City d = new City("Los Angeles, CA", 34.0522, 118.243680);
            destinationCity = d;
            
         

            FlightClass f = new FlightClass("BU Air", "A2972", o, d);
            Console.WriteLine(f.printFlightDetails());

            City o2 = new City("Louisville, KY", 38.2527, 85.7585);
            City d2 = new City("New York, NY", 40.7128, 74.0060);
            originCity = o2;
            destinationCity = d2;

            FlightClass f2 = new FlightClass("BU Air", "A2972", o2, d2);
            Console.WriteLine(f2.printFlightDetails());

            
            Console.WriteLine(toString(
                originCity, airLineName, destinationCity, flightNumber));

        }//end main


    }
}
