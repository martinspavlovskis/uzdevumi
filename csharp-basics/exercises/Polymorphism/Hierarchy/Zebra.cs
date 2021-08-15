using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Zebra : Mammal
    {

        public Zebra(string name, string type, double weight, string livingRegion)
            :base(name,type,weight,livingRegion)
        {

        }
        public override void EatFood(Food food)
        {
            if(food.GetType().Name != "Vegetable")
            {
                Console.WriteLine("Zebras dont eat meat");
                return;
            }

            FoodEaten += food.Quantity;
            MakeSound();
        }

        public override void MakeSound()
        {
            Console.WriteLine("*Zebra noises*");
        }
    }
}
