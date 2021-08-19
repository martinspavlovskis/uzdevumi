using System;
using Exercise1;
using Xunit;

namespace Exercise1.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 14, true)]
        [InlineData(13, 2, true)]
        [InlineData(17, 50, false)]
        [InlineData(10, 25, true)]
        [InlineData(10, 10, false)]
        public void CheckIfFifteen_TwoNumbers_ReturnsTrue(int num1, int num2, bool b)
        {
            //Arrange
            bool a = CheckIfFifteen.IsFifteen(num1, num2);

            //Assert
            Assert.Equal(b, a);
        }
    }
}
