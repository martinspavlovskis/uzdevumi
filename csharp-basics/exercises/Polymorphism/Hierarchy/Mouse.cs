using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Mouse : Mammal
    {

        public Mouse(string name, string type, double weight, string livingRegion)
            :base(name,type,weight,livingRegion)
        {

        }
        public override void EatFood(Food food)
        {
            if(food.GetType().Name != "Vegetable")
            {
                Console.WriteLine($"Mouses don't eat this");
                return;
            }
            FoodEaten += food.Quantity;
            MakeSound();
        }

        public override string MakeSound()
        {
            return "*Mouse noises*";
        }
    }
}
