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

        [TestMethod]
        public void GetPrimeFactorization_18_ReturnsExpectedDictionary()
        {
            // Arrange
            var number = 18;
            var expectedDictionary = new Dictionary<int, int>
            {
                [2] = 1,
                [3] = 2
            };

            // Act
            var result = PrimeHelper.GetPrimeFactorization(number);

            // Assert
            result.Should().BeEquivalentTo(expectedDictionary);
        }
    }
}
