using System.Collections.Generic;
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
    }
}
