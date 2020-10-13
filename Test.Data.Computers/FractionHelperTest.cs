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
    }
}
