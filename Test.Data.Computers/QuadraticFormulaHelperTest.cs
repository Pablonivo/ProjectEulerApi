using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class QuadraticFormulaHelperTest
    {
        [TestMethod]
        public void GetCoefficientsForQuadraticExpressionWhichProducesMaximumNumberOfPrimes_WithMaxModulus41_ReturnsCorrectCoefficients()
        {
            // Arrange
            var maxModulus = 41;

            // Act
            var result = QuadraticFormulaHelper.GetCoefficientsForQuadraticExpressionWhichProducesMaximumNumberOfPrimes(maxModulus);

            // Assert
            result.Should().Be((-1, 41));
        }
    }
}
