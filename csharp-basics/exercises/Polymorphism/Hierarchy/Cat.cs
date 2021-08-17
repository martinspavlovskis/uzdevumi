using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Cat : Feline
    {
        public string Breed { get; private set; }
        public Cat(string name, string type, double weight, string livingRegion, string breed)
            :base(name,type,weight,livingRegion)
        {
            Breed = breed;
        }
        public override void EatFood(Food food)
        {
            FoodEaten += food.Quantity;
            MakeSound();
        }

        public override string MakeSound()
        {
            return "*Cat noises*";
        }

        public override void DisplayInfo()
        {
            Console.Write($"{AnimalType} [{AnimalName}, {AnimalWeight}, {LivingRegion}, {Breed}, {FoodEaten}] ");
        }
    }
}
