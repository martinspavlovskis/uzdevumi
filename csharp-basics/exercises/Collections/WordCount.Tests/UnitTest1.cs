using System;
using Xunit;
using WordCount;

namespace WordCount.Tests
{
    public class UnitTest1
    {
        private string text = "Write a console program named\n WordCount that reads a file and reports how many lines, words, and\n characters appear in it.";
     
        [Fact]
        public void CountLines_TextInput_ReturnTrue()
        {
            //Act
            int res = WordCounter.CountLines(text);

            //Assert
            Assert.Equal(3, res);
        }

        [Fact]
        public void CountWords_TextInput_ReturnTrue()
        {
            //Act
            int res = WordCounter.CountWords(text);

            //Assert
            Assert.Equal(23, res);
        }

        [Fact]
        public void CountChars_TextInput_ReturnTrue()
        {
            //Act
            int res = WordCounter.CountChars(text);

            //Assert
            Assert.Equal(123, res);
        }
    }
}
