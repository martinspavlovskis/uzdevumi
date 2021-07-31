using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new Dog("Max", "male");
            var dog2 = new Dog("Rocky", "male");
            var dog3 = new Dog("Sparky", "male");
            var dog4 = new Dog("Buster", "male");
            var dog5 = new Dog("Sam", "male");
            var dog6 = new Dog("Lady", "female");
            var dog7 = new Dog("Molly", "female");
            var dog8 = new Dog("Coco", "female");

            dog1.mother = "Lady";
            dog1.father = "Rocky";

            dog2.mother = "Molly";
            dog2.father = "Sam";

            dog4.mother = "Lady";
            dog4.father = "Sparky";

            dog8.mother = "Lady";
            dog8.father = "Sparky";

            Console.WriteLine(dog1.FathersName());
            Console.WriteLine(dog3.FathersName());
            Console.WriteLine(dog4.HasSameMotherAs(dog8));
            Console.WriteLine(dog2.HasSameMotherAs(dog8));
        }
    }
}
