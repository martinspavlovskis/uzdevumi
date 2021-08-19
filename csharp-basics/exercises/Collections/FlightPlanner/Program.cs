using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines("flights.txt");
            var journey = new List<string>();
            var cities = GetCities(readText).ToList();
            var flights = GetFlights(readText).ToList();
            Console.WriteLine(MakeTrip(flights, cities,journey));
        }
        public static List<KeyValuePair<string,string>> GetFlights(string[]readText)
        {
            List<KeyValuePair<string, string>> flights = new List<KeyValuePair<string, string>>();

            foreach (var g in readText)
            {
                var result = g.Split(new[] { "->" }, StringSplitOptions.None);
                flights.Add(new KeyValuePair<string, string>(result[0].Trim(), result[1].Trim()));
            }
            return flights;
        }
        
        public static HashSet<string> GetCities(string[]readText)
        {
            var cities = new HashSet<string>();

            foreach (var g in readText)
            {
                var result = g.Split(new[] { "->" }, StringSplitOptions.None);
                cities.Add(result[0]);
            }            
            return cities;
        }
        public static List<string> ConnectingFlights(List<KeyValuePair<string, string>> flights, List<string> journey)
        {
            Console.Write("### \nPlease write in your selected city:");
            var selectedCity = Console.ReadLine();
            journey.Add(selectedCity);
                  
                foreach (var city in flights)
                {
                    if (selectedCity == city.Key)
                    {
                        Console.WriteLine(city.Value);
                    }
                }
                return journey;                   
        }

        public static string MakeTrip(List<KeyValuePair<string, string>> flights, List<string> cities, List<string> journey)
        {
            PrintCities(cities);
            int n = 1;
            do
            {             
                ConnectingFlights(flights,journey);
                Console.Write("CURRENT TRIP:");
                Console.WriteLine(String.Join("->", journey));
            } while (n<3);
            return "";      
        }
        public static void PrintCities(List<string>cities)
        {
            foreach(var c in cities)
            {
                Console.WriteLine(c);
            }
        }
    }
}