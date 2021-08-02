using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; private set; }
        protected Mammal(string name, string type, double weight, string livingRegion)
            :base(name,type,weight)
        {
            LivingRegion = livingRegion;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{AnimalName} [{AnimalType}, {AnimalWeight}, {LivingRegion},{FoodEaten}]");
        }
    }
}
