using System;
using Xunit;

namespace DragRace.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void NewAudiConstuctor_CreateNewAudi_ReturnsNewAudiInstance()
        {
            //Arrange
            var expected = "0";

            //Act
            var actual = new Audi();

            //Assert
            Assert.Equal(expected, actual.ShowCurrentSpeed());
        }

        [Fact]
        public void StartEngine_ToConsole_ReturnRrrrrrr()
        {
            //Arrange
            var actual = new Audi();

            //Act
            string expected = "Rrrrrrr.....";
            var result = actual.StartEngine();     

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SpeedUp_FiveTimes_ReturnExpectedSpeed()
        {
            //Arrange
            var actual = new Audi();

            //Act
            var expected = "45";

            actual.SpeedUp();
            actual.SpeedUp();
            actual.SpeedUp();
            actual.SpeedUp();
            actual.SpeedUp();

            //Assert
            Assert.Equal(expected, actual.ShowCurrentSpeed());
        }

        [Fact]
        public void SlowDown_LowerSpeed_ReturnExpectedSpeed()
        {
            //Arrange
            var actual = new Audi();

            //Act
            var expected = "2";
            
            actual.SpeedUp();
            actual.SlowDown();
            
            //Assert
            Assert.Equal(expected, actual.ShowCurrentSpeed());
        }

        [Fact]
        public void UseNitrousOxideEngine_ShouldIncrementCurrentSpeedBy_20()
        {
            //Arrange
            var actual = new Lexus();

            //Act
            var expected = "40";

            actual.UseNitrousOxideEngine();

            //Assert
            Assert.Equal(expected, actual.ShowCurrentSpeed());
        }
    }
}
