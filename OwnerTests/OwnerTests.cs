using System;
using Xunit;
using CarsLib;

namespace OwnerTests
{
    public class OwnerTests
    {
        [Theory]
        [InlineData(1234567890, 1234567890)]
        [InlineData(123, 0)]
        [InlineData(12345678901, 0)]
        public void SetLicenceNoTest(int newLicenceNo, int expectedNo)
        {
            //Arrange
            Owner o = new Owner("Test", newLicenceNo);

            //Act


            //Assert
            Assert.Equal(o.LicenceNo, expectedNo);
        }
    }
}
