using System;
using CalculateArea;
using Xunit;

namespace CalculateArea.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AreaOfCircle_Radius5_ReturnDecimal()
        {
            //Arrange
            var radius = 5;
            double expected = 78.54;

            //Act
            var res = Geometry.AreaOfCircle(radius);

            //Assert
            Assert.Equal(expected, res);
        }

        [Fact]
        public void AreaOfRectangle_Width20Height10_Return200()
        {
            //Arange
            var width = 20;
            var height = 10;
            double expected = 200;

            //Act
            var res = Geometry.AreaOfRectangle(width, height);

            //Assert
            Assert.Equal(expected, res);
        }

        [Fact]
        public void AreaOfTriangle_Ground20Height8_Return80()
        {
            //Arrange
            var ground = 20;
            var height = 8;
            double expected = 80;

            //Act
            var res = Geometry.AreaOfTriangle(ground, height);

            //Assert
            Assert.Equal(expected, res);
        }
    }
}
