using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {

        private static void Main(string[] args)
        {
            var cars = new List<Car>() 
            {
                new Skoda(),
                new Tesla(),
                new Lexus(),
                new Jaguar(),
                new Bmw(),
                new Audi()
            };

            for(int i = 0; i <= 9; i++)
            {
                foreach(var car in cars)
                {
                    car.SpeedUp();
                    if( i == 2 && car is IBoost boostedCars)
                    {
                        boostedCars.UseNitrousOxideEngine();
                    }
                }
            }

            int fastestSpeed = cars.Max(c => Convert.ToInt32(c.ShowCurrentSpeed()));
            var finished = cars.OrderBy(c => Convert.ToInt32(c.ShowCurrentSpeed()));

            
            Console.WriteLine($"The fastest car was {finished.Last()} with a speed of {fastestSpeed}");
        }
    }
}