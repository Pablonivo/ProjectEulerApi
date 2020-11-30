using Data.Computers.Solutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class Problem0014Test
    {
        // 6 -> 3 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1
        // 9 -> 28 -> 14  -> 7 -> 22 -> 11 -> 34 -> 17 -> 52 -> 26 -> 13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1
        [TestMethod]
        public void ComputeSolutionProblem14_WithUpperBound10_Returns9()
        {
            // Arrange
            var upperBound = 10;
            var expectedResult = 9;

            // Act
            var result = new Problem0014(upperBound).ComputeSolution();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}