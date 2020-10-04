using System.Collections.Generic;
using System.Linq;
using Data.Computers;
using Data.Computers.TestData;
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

        [TestMethod]
        public void GetLargestProductOfAdjacentNumbersInString_AGridWith1000Digits_ReturnsCorrectResult()
        {
            // Arrange
            var testData = TestData.Get1000digitNumberProblem8();
            var numberOfAdjacentDigits = 4;
            var expectedResult = 5832;

            // Act
            var result = NumberHelper.GetLargestProductOfAdjacentNumbersInString(testData, numberOfAdjacentDigits);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
