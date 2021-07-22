using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        private static string nameAdded;

        private static void Main(string[] args)
        {
            var mySet = new HashSet<string>();
           
            while (nameAdded != "")
            {
                Console.WriteLine("Please enter a name:");
                nameAdded = Console.ReadLine();
                mySet.Add(nameAdded);
            }

            foreach(string name in mySet)
            {
                Console.WriteLine(name);
            }

            
        }
    }
}
