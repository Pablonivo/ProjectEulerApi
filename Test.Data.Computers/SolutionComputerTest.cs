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
            var sut = new SolutionComputer();

            // Act
            var result = sut.GetSolutionOfProblem1();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
