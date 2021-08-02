using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalList = new List<Animal>();
            Console.WriteLine("Please enter the animals info:\n(Name/Type/Weight/Living Region)");
            var info = Console.ReadLine().Split(' ');
            double weight = Convert.ToDouble(info[2]);
            while (true)
            {
                if (info[1] == "Zebra")
                {
                    animalList.Add(new Zebra(info[0], info[1], weight, info[3]));
                    
                }
                else if (info[1] == "Tiger")
                {
                    animalList.Add(new Tiger(info[0], info[1], weight, info[3]));
                }
                else if (info[1] == "Mouse")
                {
                    animalList.Add(new Mouse(info[0], info[1], weight, info[3]));
                }
                else if (info[1] == "Cat")
                {
                    animalList.Add(new Cat(info[0], info[1], weight, info[3], info[4]));
                }
                
                animalList[animalList.Count - 1].MakeSound();

                Console.WriteLine("Enter the food type and quantity:");
                var foodInfo = Console.ReadLine().Split(' ');
                var foodType = foodInfo[0];
                var quantity = foodInfo[1];
                if(foodType == "Meat")
                {
                    var meat = new Meat(Convert.ToInt32(quantity));
                    animalList[animalList.Count - 1].EatFood(meat);
                    
                } else if(foodType == "Vegetable")
                {
                    var veg = new Vegetable(Convert.ToInt32(quantity));
                    animalList[animalList.Count - 1].EatFood(veg);
                }else if(foodType == "End")
                {
                    break;
                }
                animalList[animalList.Count - 1].DisplayInfo();
            }

            foreach (var a in animalList)
            {
                a.DisplayInfo();
            }

            Console.ReadKey();
        }
    }
}