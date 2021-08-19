using System;
using Exercise6;
using Xunit;

namespace Exercise6.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GenerateArray_NewArrayWithSameNumbers_ReturnsFalse()
        {
            // Arrange
            var arr1 = ArrayExtensions.GenerateRandomNumberArray();

            // Act
            var arr2 = ArrayExtensions.MakeNewArray(arr1);

            // Assert
            Assert.False(arr1 == arr2);           
        }
    }
}
