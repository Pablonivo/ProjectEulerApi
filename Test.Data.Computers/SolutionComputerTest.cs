using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SolutionComputerTest
    {
        [TestMethod]
        public void GetSolutionOfProblem1_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 233168;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem1();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem2_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 4613732;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem2();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
