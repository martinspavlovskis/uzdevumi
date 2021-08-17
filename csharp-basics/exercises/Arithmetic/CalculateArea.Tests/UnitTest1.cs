using System;
using CalculateArea;
using Xunit;

namespace CalculateArea.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AreaOfCircle_Radius10_ReturnDecimal()
        {
            var radius = 5;
            double expected = 78.54;

            var res = Math.Round(Geometry.AreaOfCircle(radius), 2);

            Assert.Equal(expected, res);
        }

        [Fact]
        public void AreaOfRectangle_WidthHeight10_100()
        {
            var width = 20;
            var height = 10;
            double expected = 200;

            var res = Math.Round(Geometry.AreaOfRectangle(width, height), 2);

            Assert.Equal(expected, res);
        }

        [Fact]
        public void AreaOfTriangle_WidthHeight10_100()
        {
            var ground = 20;
            var height = 8;
            double expected = 80;

            var res = Math.Round(Geometry.AreaOfTriangle(ground, height), 2);

            Assert.Equal(expected, res);
        }
    }
}
