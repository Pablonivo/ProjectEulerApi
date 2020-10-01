using System.Collections.Generic;
using System.Linq;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class NumberHelperTest
    {
        [TestMethod]
        public void GetMultiplesOfNumberBelowMax_WhenAskedForMultiplesOf3Below10_ReturnsCorrectList()
        {
            // Arrange
            var number = 3;
            var max = 10;
            var expectedResult = new List<int> { 3, 6, 9 };

            // Act
            var result = NumberHelper.GetMultiplesOfNumberBelowMax(number, max);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void GetSmallestMultiple_WhenAskedForSmallestMultipleOfIntegersFrom1To10_ReturnsCorrectList()
        {
            // Arrange
            var numberList = Enumerable.Range(1, 10).ToList();
            var expectedResult = 2520;

            // Act
            var result = NumberHelper.GetSmallestMultiple(numberList);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
