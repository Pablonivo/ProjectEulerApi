using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class FactorialHelperTest
    {
        [TestMethod]
        public void Factorial_Of5_Returns120()
        {
            // Arrange
            var n = 5;
            var expectedResult = 120;

            // Act
            var result = FactorialHelper.Factorial(n);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void BinominalCoefficient_Of4Over2_Returns6()
        {
            // Arrange
            var n = 4;
            var k = 2;
            var expectedResult = 6;

            // Act
            var result = FactorialHelper.BinominalCoefficient(n, k);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void IsSumOfFactorialOfDigits_Of145_ReturnsTrue()
        {
            // Arrange
            var number = 145;

            // Act
            var result = FactorialHelper.IsSumOfFactorialOfDigits(number);

            // Assert
            result.Should().BeTrue();
        }
    }
}
