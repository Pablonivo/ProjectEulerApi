using Data.Computers.Solutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class Problem0060Test
    {
        [TestMethod]
        public void ComputeSolutionProblem60_For4Ptimes_Returns792()
        {
            // Arrange
            var upperBoundOfPrimes = 700;
            var requiredNumberOfPrimes = 4;
            var lowestSum = 792;

            // Act
            var result = new Problem0060(upperBoundOfPrimes, requiredNumberOfPrimes).ComputeSolution();

            // Assert
            result.Should().Be(lowestSum);
        }
    }
}