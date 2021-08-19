using System;
using Exercise2;
using Xunit;

namespace Exercise2.Tests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(20)]
        [InlineData(10)]
        [InlineData(2)]
        [InlineData(1000)]
        public void CheckIfOddOrEven_Number_ReturnEvenNumberString(int num)
        {

            //Act
            var result = CheckIfOddOrEven.CheckIfEvenOrOdd(num);

            //Assert
            Assert.Equal("Even number", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(5)]
        [InlineData(99)]
        public void CheckIfOddOrEven_Number_ReturnOddNumberString(int num)
        {

            //Act
            var result = CheckIfOddOrEven.CheckIfEvenOrOdd(num);

            //Assert
            Assert.Equal("Odd number", result);
        }
    }   
}
