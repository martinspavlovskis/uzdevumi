using System;
using Exercise8;
using Xunit;

namespace Exercise8.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void CalculateSalary_HourlyWageLowerThanMinimum_ReturnError()
        {
            var wage = 1;
            var hoursWorked = 50;
            Action error = () => CalculateSalaries.CalculateSalary(wage, hoursWorked);

            ArgumentException exception = Assert.Throws<ArgumentException>(error);
            Assert.Equal("Error", exception.Message);
        }

        [Theory]
        [InlineData(10,50,550)]
        [InlineData(12,40,480)]
        public void CalculateSalary_ValidHoursAndWage_ReturnsSalary(double wage,int hoursWorked,double salary)
        {
            var expected = CalculateSalaries.CalculateSalary(wage, hoursWorked);
            Assert.Equal(expected, salary);
        }
        
    }
}
