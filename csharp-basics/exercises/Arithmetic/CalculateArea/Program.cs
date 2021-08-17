using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice; 

            do
            {              
                choice = getMenu();

                if (choice == 1)
                {                  
                    Console.WriteLine("Please enter the radius");
                    var radius = Convert.ToDouble(Console.ReadKey());
                    Console.WriteLine($"The are of the circle is:{Geometry.AreaOfCircle(radius)}");
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Please enter the length");
                    var length = Convert.ToDouble(Console.ReadKey());
                    Console.WriteLine("Please enter the width");
                    var width = Convert.ToDouble(Console.ReadKey());
                    Console.WriteLine($"The are of the circle is:{Geometry.AreaOfRectangle(length,width)}");
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Please enter the ground");
                    var ground = Convert.ToDouble(Console.ReadKey());
                    Console.WriteLine("Please enter the height");
                    var height = Convert.ToDouble(Console.ReadKey());
                    Console.WriteLine($"The are of the circle is:{Geometry.AreaOfTriangle(ground, height)}");
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int getMenu()
        {
            int userChoice;
    
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            
            int.TryParse(keyboard.KeyChar.ToString(), out userChoice);
            
            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                keyboard = Console.ReadKey();
                userChoice = keyboard.KeyChar;
            }
            return userChoice;
        }
    }
}
