using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Tiger : Feline
    {
        public Tiger(string name, string type, double weight, string livingRegion)
            :base(name,type,weight,livingRegion)
        {

        }
        public override void EatFood(Food food)
        {
            if(food.GetType().Name != "Meat")
            {
                Console.WriteLine("Tigers dont eat this");
            } else
            {
                FoodEaten += food.Quantity;
                MakeSound();
            }
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("*tiger noises*");
        }
    }
}
