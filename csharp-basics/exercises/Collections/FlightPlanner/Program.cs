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
            var readText = File.ReadAllText("flights.txt").Trim().Replace(">", "").Split('-');

            
            HashSet<string> Cities = new HashSet<string>(readText);
            var c = new List<string>();
            

            foreach (var s in readText)
            {
                c.Add(s);
                
                Console.WriteLine(s);
            }
            c.Distinct().ToList();
            Console.WriteLine(String.Join(",",c));
        }
    }
}
