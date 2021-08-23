using System;
using System.Linq;
using Exercise6;
using Xunit;

namespace Exercise6.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void MakeNewArrayFromExistingArray_ReturnLastNumbersOfArrays_Negative7Expected()
        {
            // Arrange
            var arr1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var arr2 = ArrayExtensions.MakeNewArrayFromExistingArray(arr1);
            var expected = -7;

            //Act
            var last = arr2.Last();

            // Assert
            Assert.Equal(expected,last);           
        }
    }
}
