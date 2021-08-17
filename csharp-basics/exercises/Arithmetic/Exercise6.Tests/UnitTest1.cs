using System;
using Xunit;

namespace Exercise6.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, "Coza ")]
        [InlineData(94, "94 ")]
        [InlineData(7, "CozaLoza ")]
        [InlineData(110, "Woza ")]
        [InlineData(19, "19 ")]
        [InlineData(20, "Woza ")]
        public void CozaLoza_IndexAndValue_ReturnTrue(int num, string value)
        {
            string result = CozaLoza.MakeCoza(num);
            Assert.Equal(value,result);
        }
    }
}
