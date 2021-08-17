using System;
using Xunit;

namespace Exercise5.Tests
{
    public class UnitTest1
    {
        private readonly Date myDate = new Date(5, 4, 1999);

        [Fact]
        public void DisplayDate_Date()
        {
            string result = myDate.DisplayDate();
            string expected = "5/4/1999";
            Assert.Equal(expected, result);
        }
    }
}
