using Data.Entities;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Entities
{
    [TestClass]
    public class FractionTest
    {
        [DataRow(13, 6, 13, 6)]
        [DataRow(28, 6, 14, 3)]
        [DataRow(15, 40, 3, 8)]
        [TestMethod]
        public void Constructor_SimplifiesFractions(int a, int b, int expectedNumerator, int expectedDenominator)
        {
            var fraction = new Fraction(a, b);
            fraction.Numerator.Should().Be(expectedNumerator);
            fraction.Denominator.Should().Be(expectedDenominator);
        }

        [TestMethod]
        public void DefaultSum_ReturnsCorrectResult()
        {
            // Arrange
            var fractionA = new Fraction(3, 16);
            var fractionB = new Fraction(2, 8);
            var expectedNumerator = 7;
            var expetedDenominator = 16;

            // Act
            var sum = fractionA + fractionB;

            // Assert
            sum.Numerator.Should().Be(expectedNumerator);
            sum.Denominator.Should().Be(expetedDenominator);
        }

        [TestMethod]
        public void SumWithInteger_ReturnsCorrectResult()
        {
            // Arrange
            var integer = 6;
            var fraction = new Fraction(3, 16);
            var expectedNumerator = 99;
            var expetedDenominator = 16;

            // Act
            var sum = integer + fraction;

            // Assert
            sum.Numerator.Should().Be(expectedNumerator);
            sum.Denominator.Should().Be(expetedDenominator);
        }

        [TestMethod]
        public void Product_ReturnsCorrectResult()
        {
            // Arrange
            var fractionA = new Fraction(2, 3);
            var fractionB = new Fraction(1, 4);
            var expectedNumerator = 1;
            var expetedDenominator = 6;

            // Act
            var sum = fractionA * fractionB;

            // Assert
            sum.Numerator.Should().Be(expectedNumerator);
            sum.Denominator.Should().Be(expetedDenominator);
        }

        [TestMethod]
        public void Division_ReturnsCorrectResult()
        {
            // Arrange
            var fractionA = new Fraction(1, 3);
            var fractionB = new Fraction(2, 6);
            var expectedNumerator = 1;
            var expetedDenominator = 1;

            // Act
            var sum = fractionA / fractionB;

            // Assert
            sum.Numerator.Should().Be(expectedNumerator);
            sum.Denominator.Should().Be(expetedDenominator);
        }

        [TestMethod]
        public void IntegerDividedByFraction_ReturnsCorrectResult()
        {
            // Arrange
            var integer = 6;
            var fraction = new Fraction(6, 28);
            var expectedNumerator = 28;
            var expetedDenominator = 1;

            // Act
            var sum = integer / fraction;

            // Assert
            sum.Numerator.Should().Be(expectedNumerator);
            sum.Denominator.Should().Be(expetedDenominator);
        }
    }
}
