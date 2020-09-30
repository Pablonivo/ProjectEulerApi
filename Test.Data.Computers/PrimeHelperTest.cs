using System.Collections.Generic;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class PrimeHelperTest
    {
        [TestMethod]
        public void GetPrimesFactors_13195_ReturnsExpectedList()
        {
            // Arrange
            var number = 13195;
            var expectedResult = new List<long> { 5, 7, 13, 29 };

            // Act
            var result = PrimeHelper.GetPrimesFactors(number);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
