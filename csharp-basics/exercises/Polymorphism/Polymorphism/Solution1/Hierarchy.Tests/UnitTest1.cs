using System;
using Xunit;
using Hierarchy;

namespace Hierarchy.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CreateNewCat_ReturnsNewCatInstance()
        {
            //Arrange
            var name = "Bille";
            var type = "Cat";
            var animalWeight = 4;
            var region = "Riga";
            var breed = "Black Cat";
            //Act
            var actual = new Cat("Bille", "Cat", 4, "Riga", "Black Cat");

            //Assert
            Assert.Equal(type, actual.AnimalType);
            Assert.Equal(name, actual.AnimalName);
            Assert.Equal(animalWeight, actual.AnimalWeight);
            Assert.Equal(region, actual.LivingRegion);
            Assert.Equal(breed, actual.Breed);
        }

        [Fact]
        public void EatFood_AddFoodTwoTimes_ReturnsCorrectFoodAmountEaten()
        {
            //Arrange
            var equals = 10;
            //Act
            var actual = new Cat("Bille", "Cat", 4, "Riga", "Black Cat");
            var food = new Meat(5);
            actual.EatFood(food);
            actual.EatFood(food);
            //Assert
            Assert.Equal(equals, actual.FoodEaten);

        }

        [Fact]
        public void MakeSound_InputAnimalData_pipipiExpected()
        {
            // Arrange
            var actual = new Mouse("Mouse", "Rat", 0.3, "Cave");
            var expected = "*Mouse noises*";
            
            
            // Assert
            Assert.Equal(expected, actual.MakeSound());
        }
    }
}
