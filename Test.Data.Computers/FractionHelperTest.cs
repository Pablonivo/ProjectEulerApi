using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class FractionHelperTest
    {
        [TestMethod]
        public void GetRecurringCycleOfFraction_Of1Over7_ReturnsCorrectCycle()
        {
            // Arrange
            var numerator = 1;
            var denominator = 7;
            var expectedRecurringCycle = 142857;

            // Act
            var result = FractionHelper.GetRecurringCycleOfFraction(numerator, denominator);

            // Assert
            result.Should().Be(expectedRecurringCycle);
        }

        [TestMethod]
        public void GetListOfFractionsThatCanBeSimplifiedIncorrectly_WithAtMost2Digits_Returns4()
        {
            // Arrange
            var maxSizeOfFractionalParts = 99;
            var expectedNumberOfFractions = 4;

            // Act
            var result = FractionHelper.GetListOfFractionsThatCanBeSimplifiedIncorrectly(maxSizeOfFractionalParts);

            // Assert
            result.Should().HaveCount(expectedNumberOfFractions);
        }

        [TestMethod]
        public void CanFractionBeSimplifiedIncorrectly_Of49Over98_ReturnsTrue()
        {
            // Arrange
            var numerator = 49;
            var denominator = 98;

            // Act
            var result = FractionHelper.CanFractionBeSimplifiedIncorrectly(numerator, denominator);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void ToLowestTerms_Of49Over98_Returns1Over2()
        {
            // Arrange
            var numerator = 49;
            var denominator = 98;
            var expectedResult = (1, 2);

            // Act
            var result = FractionHelper.ToLowestTerms(numerator, denominator);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
