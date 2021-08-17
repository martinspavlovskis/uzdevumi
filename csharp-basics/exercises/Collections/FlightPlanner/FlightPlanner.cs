using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class FlightPlanner
    {
        public static List<KeyValuePair<string, string>> Flights = new List<KeyValuePair<string, string>>();

        public FlightPlanner()
        {
            Flights = new List<KeyValuePair<string, string>>();
        }

        public static void AddFlights(string departure, string arrival)
        {
            Flights.Add(new KeyValuePair<string, string>(departure, arrival));
        }
        public static void PrintFlights()
        {
            foreach (var flight in Flights)
            {
                Console.WriteLine(flight);
            }
        }
    }
}
