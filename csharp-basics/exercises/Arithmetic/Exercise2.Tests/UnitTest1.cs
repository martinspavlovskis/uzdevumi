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
        public void CheckIfOddOrEven_ReturnEvenNumberString(int num)
        {

            var result = CheckIfOddOrEven.CheckIfEvenOrOdd(num);

            Assert.Equal("Even number", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(5)]
        [InlineData(99)]
        public void CheckIfOddOrEven_ReturnOddNumberString(int num)
        {

            var result = CheckIfOddOrEven.CheckIfEvenOrOdd(num);

            Assert.Equal("Odd number", result);
        }
    }   
}
