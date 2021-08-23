using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using Xunit;

namespace FlightPlanner.Tests
{

    public class UnitTest1
    {

        private List<KeyValuePair<string, string>> flights = new List<KeyValuePair<string, string>>();

        [Fact]
        public void GetFlights_Flights_ReturnTrue()
        {
            //Arrange
            string[] readText = { "San Jose -> San Francisco", "San Jose -> Anchorage", "New York -> Anchorage", "New York -> San Jose" };
            flights = Program.GetFlights(readText);

            //Act
            var result = flights[0].ToString();
            var expect = new KeyValuePair<string, string>("San Jose", "San Francisco").ToString();

            //Assert
            Assert.Contains(result, expect);     
        }

        [Fact]
        public void GetCities_ArrayCount4_returnCorrectCount()
        {
            // Arrange
            string[] arr = { "San Jose", "San Francisco", "Anchorage", "Anchorage" };

            // Act
            var result = Program.GetCities(arr);

            // Assert
            Assert.Equal(3, result.Count);
        }
    }
}