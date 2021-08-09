using System;
using Xunit;
using CarsLib;

namespace CarsLibTests
{
    public class CarTests
    {
        [Theory]
        [InlineData(50, 20, 70)]
        [InlineData(120, 20, 130)]
        [InlineData(130, 10000, 130)]

        [InlineData(0, -5, -5)]
        [InlineData(0, -10, -10)]
        [InlineData(40, -100, -10)]
        public void AddSpeedTest(int startingSpeed, int speedToAdd, int expected)
        {
            //Arrange
            Car c = new Car("AAAAAA", startingSpeed);


            //Act
            c.AddSpeed(speedToAdd);


            //Assert
            Assert.Equal(c.Speed, expected);
        }

        [Theory]
        [InlineData("BBBBBB", "BBBBBB")]
        [InlineData("CCCCCCCCCCC", "CCCCCC")]
        [InlineData("DDDD", "DDDDAA")]
        public void SetRegoTest(string newRego, string expected)
        {
            //Arrange
            Car c = new Car("ZZZZZZ", 10);

            //Act
            c.SetRego(newRego);

            //Assert
            Assert.Equal(c.Rego, expected);
        }

        [Theory]
        [InlineData("BBBBBB", "BBBBBB", -20, -10)]
        [InlineData("CCCCCCCCCCC", "CCCCCC", 50, 50)]
        [InlineData("DDDD", "DDDDAA", 140, 130)]
        public void ConstructorTest(string newRego, string expectedRego, int newSpeed, int expectedSpeed)
        {
            //Arrange
            Car c = new Car(newRego, newSpeed);


            //Assert
            Assert.Equal(expectedRego, c.Rego);
            Assert.Equal(expectedSpeed, c.Speed);
        }
    }
}
