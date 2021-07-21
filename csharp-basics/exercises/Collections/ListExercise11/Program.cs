using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink",
                "Yellow",
                "Beige",
                "Grey",
                "Blue",
                "Brown"
            };

            //TODO: Add new value at 5th position
            colors.Insert(4, "Magenta");

            //TODO: Change value at last position (Calculate last position programmatically)
            colors[colors.Count - 1] = "Amber";

            //TODO: Sort your list in alphabetical order
            colors.Sort();

            //TODO: Check if your list contains "Foobar" element
            if (colors.Contains("Foobar"))
            {
                Console.WriteLine("Contains");
            } else
            {
                Console.WriteLine("Doesnt contain");
            }

            //TODO: Print each element of list using loop
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
