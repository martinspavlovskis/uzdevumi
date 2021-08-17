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
            _phoneDirectory.PutNumber("john", "123");
            _phoneDirectory.PutNumber("karl", "12345");
            _phoneDirectory.PutNumber("marti", "123456");

            var res = _phoneDirectory._data.Count;
            var expected = 3;
            Assert.Equal(res, expected);

        }

        [Theory]
        [InlineData("guna", "123")]
        
        public void Finder_NameNotAdded_ReturnFalse(string name, string number)
        {
            string result = _phoneDirectory.Finder(name);
            Assert.False(number == result);
        }

        [Fact]
        public void PutNumber_AddBlankName_ThrowException()
        {
            var name = "";
            var number = "12345678";

            Action res = () => _phoneDirectory.PutNumber(name, number);
            ArgumentException exception = Assert.Throws<ArgumentException>(res);
            Assert.Equal("name and/or number cant be null", exception.Message);
        }

    }
}
