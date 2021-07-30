using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        
        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines("flights.txt");
            var cities = new HashSet<string>();
            List<KeyValuePair<string, string>> flights = new List<KeyValuePair<string, string>>();
            var journey = new List<string>();

            foreach (var g in readText)
            {
                var result = g.Split(new[] { "->" }, StringSplitOptions.None);               
                flights.Add(new KeyValuePair<string,string>(result[0].Trim(), result[1].Trim()));
            }
            
            string ShowCities()
            {
                foreach (var g in readText)
                {
                    var result = g.Split(new[] { "->" }, StringSplitOptions.None);
                    cities.Add(result[0]);                   
                }
                Console.WriteLine(String.Join("\n", cities));
                return "";
                
            }
            
            Console.WriteLine("To see available cities press 1 \nTo close this program press # ");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Available cities: \n###");
                ShowCities();

                Console.Write("### \nPlease write in your selected city:");
                var selectedCity = Console.ReadLine();
                journey.Add(selectedCity);

                Console.WriteLine($"Destinations from {selectedCity} are:\n###");
                foreach (var city in flights)
                {
                    if (selectedCity == city.Key)
                    {
                        Console.WriteLine(city.Value);
                    }
                }
                Console.Write("###\nPlease write in your destination:");
                selectedCity = Console.ReadLine();
                journey.Add(selectedCity);
                Console.WriteLine($"To see flights from {selectedCity} press 2. To finish planning your journey press #");
                input = Console.ReadLine();

                while(input == "2")
                {
                    Console.WriteLine($"Destinations from {selectedCity} are:\n###");
                    foreach (var city in flights)
                    {
                        if (selectedCity == city.Key)
                        {
                            Console.WriteLine(city.Value);
                        }
                    }
                    Console.Write("###\nPlease write in your destination: ");
                    selectedCity = Console.ReadLine();
                    journey.Add(selectedCity);

                    Console.Write($"To see flights from {selectedCity} press 2. To finish planning your journey press #");
                    input = Console.ReadLine();
                }

               while(input == "#")
                {
                    Console.WriteLine("Your selected journey:");
                    Console.WriteLine(string.Join("-> ", journey));
                    break;
                }


            } else if (input != "1")
            {
                Console.WriteLine("Closing Program.....");            
            }        
            Console.ReadKey();
        }
        
    }
}
