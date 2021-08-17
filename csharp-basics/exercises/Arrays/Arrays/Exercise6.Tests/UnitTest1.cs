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
            var arr1 = ArrayExtensions.GenerateRandomNumberArray();

            var arr2 = ArrayExtensions.MakeNewArray(arr1);

            Assert.False(arr1 == arr2);           
        }
    }
}
