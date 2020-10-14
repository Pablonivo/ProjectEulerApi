using System.Collections.Generic;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class PandigitalHelperTest
    {
        [TestMethod]
        public void GetPandigitalNumbers_ForNumbersFrom1To3_ReturnsCorrectList()
        {
            // Arrange
            var charsAllowedToUse = new List<char> { '1', '2', '3' };
            var expectedResult = new List<string> { "123", "132", "213", "231", "312", "321" };

            // Act
            var result = PandigitalHelper.GetPandigitalNumbers(charsAllowedToUse);

            // ASsert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void IsPandigitalProduct_For391867254_ReturnsTrueAnd7254()
        {
            // Arrange
            var pandigitalNumber = "391867254";
            var expectedResult = (true, 7254); // 39 * 196 = 7254

            // Act
            var result = PandigitalHelper.IsPandigitalProduct(pandigitalNumber);

            // ASsert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
