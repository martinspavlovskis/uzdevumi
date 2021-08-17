using System;
using Xunit;

namespace Exercise1.Tests
{
    public class UnitTest1
    {

        Product phone = new Product("Phone", 500, 10);

        [Fact]
        public void ChangePrice_ReturnChangedPrice()
        {
            double result = phone.ChangePrice(550);
            double expected = 550;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ChangeQuantity_ReturnChangedQuantity()
        {
            double result = phone.ChangeQuantity(8);
            double expected = 8;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PrintProduct_ReturnPrintedInfo()
        {
            string result = phone.PrintProduct();
            string expected = "Phone, price 500, amount 10";
            Assert.Equal(expected, result);
        }
    }
}
