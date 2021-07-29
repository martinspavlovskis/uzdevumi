using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    { 
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> list = array.ToList();
            foreach (string brand in array)
            {
                Console.WriteLine(brand);
            }

            HashSet<string> hashSet = array.ToHashSet();
            foreach (string brand in hashSet)
            {
                Console.WriteLine(brand);
            }

            var dictionary = new Dictionary<string, string>()
                {
                    {"Audi", "Germany"},
                    {"BMW", "Germany"},
                    {"Honda", "Japan"},
                    {"Mercedes", "Germany"},
                    {"Volkswagen", "Germany"},
                    {"Tesla", "USA"}
                };
            foreach (var x in dictionary)
            {
                Console.WriteLine($"{x.Key} => {x.Value}");
            }
        }
    }
}
