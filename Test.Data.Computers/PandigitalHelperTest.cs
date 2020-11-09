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
        public void ConcatenatedProduct_Of192AndNumbers1To3_ReturnsCorrectString()
        {
            // Arrange
            var integer = 192;
            var numbersToMultiplyWith = new List<int> { 1, 2, 3 };
            var expectedResult = "192384576";

            // Act
            var result = PandigitalHelper.ConcatenatedProduct(integer, numbersToMultiplyWith);

            // ASsert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void ConcatenatedProduct_Of9AndNumbers1To5_ReturnsCorrectString()
        {
            // Arrange
            var integer = 9;
            var numbersToMultiplyWith = new List<int> { 1, 2, 3, 4, 5 };
            var expectedResult = "918273645";

            // Act
            var result = PandigitalHelper.ConcatenatedProduct(integer, numbersToMultiplyWith);

            // ASsert
            result.Should().Be(expectedResult);
        }

        [DataRow("192384576", true)]
        [DataRow("0192384576", false)]
        [TestMethod]
        public void Is1To9Pandigital_ReturnsCorrectResult(string number, bool expectedResult)
        {
            PandigitalHelper.Is1To9Pandigital(number).Should().Be(expectedResult);
        }
    }
}
