using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string AnimalName { get; private set; }
        public string AnimalType { get; private set; }
        public double AnimalWeight { get; private set; }
        public int FoodEaten { get; set; }

        protected Animal(string name, string type, double weight)
        {
            AnimalName = name;
            AnimalType = type;
            AnimalWeight = weight;
        }


        public abstract void MakeSound();
        public abstract void EatFood(Food food);
        public abstract void DisplayInfo();
    }
}
