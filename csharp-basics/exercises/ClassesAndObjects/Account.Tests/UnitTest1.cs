using System;
using Xunit;
using Account;

namespace Account.Tests
{
    public class UnitTest1
    {
        Acc test = new Acc("testAccount", 1000);

        [Fact]
        public void Withdraw_NotEnoughMoney_ReturnException()
        {   
            //Act
            Action act = () => { test.Withdrawal(1500); };
            ArgumentException exception = Assert.Throws<ArgumentException>(act);

            //Assert
            Assert.Equal("You dont have enough money", exception.Message);
        }

        [Fact]
        public void Deposit_Deposit100_ReturnCorrectAmount()
        {
            //Arrange
            double result = test.Deposit(100);

            //Act
            double expected = 1100;

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Withdrawal_Withdraw100_ReturnCorrectAmount()
        {
            //Arrange
            double result = test.Withdrawal(500);

            //Act
            double expected = 500;

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Balance_ReturnCorrectString()
        {
            //Act
            string result = test.Balance();
            
            //Assert
            Assert.Equal("Account name: testAccount, Balance: 1000", result);
        }
    }
}
