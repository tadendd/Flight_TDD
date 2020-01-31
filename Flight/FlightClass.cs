using System;
using System.Globalization;
using System.Text;

namespace Flight
{
    public class FlightClass : City
    {
		public static String airLineName;
		public static City originCity;
		public static City destinationCity;
		public static String flightNumber;
        private string v1;
        private string v2;
        private City o;
        private City d;

        public FlightClass(string v1, string v2, City o, City d)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.o = o;
            this.d = d;
        }

        /**
		 * Empty-argument constructor to put 
		 * the object into a consistent state.
		 */
        public void Flight()
		{
           

		}//end constructor

		/**
		 * Preferred constructor for this object
		 * @param aln - airline number
		 * @param fn - flight number
		 * @param o - origin city
		 * @param d - destination city
		 */
		public void Flight(String aln, String fn, City o, City d)
		{

			setAirLineName(aln);
			setFlightNumber(fn);
			setOriginCity(o);
			setDestinationCity(d);

		}//end constructor

		/**
		 * Method uses the haversine formulae
		 * to calculate the distance around the 
		 * globe from one city to another.
		 * @return - distance in miles
		 */
		public double calcDistanceToFly()
		{

			double R = 6371000;
			double lat1 = originCity.getLatitude();
			double lat2 = destinationCity.getLatitude();
			double lon1 = originCity.getLongitude();
			double lon2 = destinationCity.getLongitude();

			double lat1Radians = ((Math.PI / 180) * lat1);
			double lat2Radians = ((Math.PI / 180) * lat2);
			double lon1Radians = ((Math.PI / 180) * lon1);
			double lon2Radians = ((Math.PI / 180) * lon2);

			double deltaLat = ((Math.PI / 180) * (lat2 - lat1));
			double deltaLon = ((Math.PI / 180) * (lon2 - lon1));

			double a = Math.Pow(Math.Sin(deltaLat / 2), 2) + Math.Cos(lat1Radians) * Math.Cos(lat2Radians) * Math.Pow(Math.Sin(deltaLon / 2), 2);

			double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

			double distance = R * c;

			return distance * 0.000621371;
		}//end 


		/**
		 * This method will return all of the flight
		 * details including the airline, flight number,
		 * and distance between two city objects.
		 * @return -String representing the flight details
		 */
		public String printFlightDetails()
		{

            NumberFormatInfo formatter = NumberFormatInfo.GetInstance(null);
            double DistanceToFly = this.calcDistanceToFly();
            StringBuilder sb = new StringBuilder();

			sb.Append(airLineName + " " + flightNumber + "\n");
			sb.Append(originCity.getName() + " to " + destinationCity.getName() + "\n");
			sb.Append("Distance: " + DistanceToFly + " miles.\n");
            

			return sb.ToString();
		}//end printFlightDetails

		/**
		 * getter for airLineName
		 * @return
		 */
		public String getAirLineName()
		{
			return airLineName;
		}//end getAirline

		/**
		 * Setter for airLineName
		 * @param airLineName
		 */
		public void setAirLineName(String airLineName)
		{
			airLineName = airLineName;
		}//end setAirLineName

		/**
		 * Getter for flightNumber
		 * @return
		 */
		public String getFlightNumber()
		{
			return flightNumber;
		}//end getFlightNumber

		/**
		 * Setter for flightNumber
		 * @param flightNumber
		 */
		public void setFlightNumber(String flightNumber)
		{
			flightNumber = flightNumber;
		}//end setFlightNumber

		/**
		 * Getter for originCity
		 * @return
		 */
		public static City getOriginCity(string v)
		{
			return originCity;
		}//end getOriginCity

		/**
		 * Setter for originCity
		 * @param originCity
		 */
		public void setOriginCity(City originCity)
		{
			originCity = originCity;
		}//end setOriginCity
        
		/**
		 * Getter for destinationCity
		 * @return
		 */
		public static City getDestinationCity(string v)
		{
			return destinationCity;
		}//end getDestinationCity

		/**
		 * Setter for destinationCity
		 * @param destinationCity
		 */
		public void setDestinationCity(City destinationCity)
		{
			destinationCity = destinationCity;
		}//end setDestinationCity

		
	public static String toString(City originCity, string airLineName, City destinationCity, string flightNumber)
		{
			return "Flight [airLineName=" + airLineName + ", originCity=" + originCity + ", destinationCity="
					+ destinationCity + ", flightNumber=" + flightNumber + "]";
		}//end toString


	}//end class


}
