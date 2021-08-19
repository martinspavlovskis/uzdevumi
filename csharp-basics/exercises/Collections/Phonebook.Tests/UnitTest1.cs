using System;
using Xunit;
using PhoneBook;
using System.Collections.Generic;

namespace Phonebook.Tests
{
    public class UnitTest1
    {
        private PhoneDirectory _phoneDirectory;
        public UnitTest1()
        {
            _phoneDirectory = new PhoneDirectory();
        } 

        [Fact]

        public void PutNumber_Names_ReturnLength()
        {
            //Arrange
            _phoneDirectory.PutNumber("john", "123");
            _phoneDirectory.PutNumber("karl", "12345");
            _phoneDirectory.PutNumber("marti", "123456");

            //Act
            var res = _phoneDirectory._data.Count;
            var expected = 3;

            //Assert
            Assert.Equal(res, expected);

        }

        [Theory]
        [InlineData("guna", "123")]
        
        public void Finder_NameNotAdded_ReturnFalse(string name, string number)
        {
            //Act
            string result = _phoneDirectory.Finder(name);

            //Assert
            Assert.False(number == result);
        }

        [Fact]
        public void PutNumber_AddBlankName_ThrowException()
        {
            //Arrange
            var name = "";
            var number = "12345678";

            //Act
            Action res = () => _phoneDirectory.PutNumber(name, number);
            ArgumentException exception = Assert.Throws<ArgumentException>(res);

            //Assert
            Assert.Equal("name and/or number cant be null", exception.Message);
        }

    }
}
