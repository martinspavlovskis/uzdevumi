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
            var actual = new Audi();

            string expected = "Rrrrrrr.....";

            var result = actual.StartEngine();     

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SpeedUp_FiveTimes_ReturnExpectedSpeed()
        {
            var actual = new Audi();

            var expected = "45";

            actual.SpeedUp();
            actual.SpeedUp();
            actual.SpeedUp();
            actual.SpeedUp();
            actual.SpeedUp();

            Assert.Equal(expected, actual.ShowCurrentSpeed());
        }

        [Fact]
        public void SlowDown_LowerSpeed_ReturnExpectedSpeed()
        {
            var actual = new Audi();

            var expected = "2";
            
            actual.SpeedUp();
            actual.SlowDown();
            
            Assert.Equal(expected, actual.ShowCurrentSpeed());
        }

        [Fact]
        public void UseNitrousOxideEngine_ShouldIncrementCurrentSpeedBy_20()
        {
            var actual = new Lexus();
            var expected = "40";

            actual.UseNitrousOxideEngine();

            

            Assert.Equal(expected, actual.ShowCurrentSpeed());
        }
    }
}
