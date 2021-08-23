using System;
using GravityCalculator;
using Xunit;

namespace GravityCalculator.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 10, 0, 490.5)]
        [InlineData(0,10,10,500.5)]      
        public void CalculateFinalPosition_ValidParams_ReturnFinalPosition(double startPosition, double time, double velocity, double finalPosition)
        {
            //Act
            var actual = GravityCalculator.CalculateFinalPosition(startPosition, time, velocity);

            //Assert
            Assert.Equal(finalPosition, actual);
        }
    }
}
