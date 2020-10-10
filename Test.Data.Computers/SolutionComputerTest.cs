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

        [TestMethod]
        public void GetSolutionOfProblem3_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6857;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem3();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem4_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 906609;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem4();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem5_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 232792560;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem5();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem6_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 25164150;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem6();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem7_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 104743;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem7();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem8_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 23514624000;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem8();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem9_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 31875000;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem9();

            // Assert
            result.Should().Be(expectedResult);
        }


        [TestMethod]
        public void GetSolutionOfProblem10_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 142913828922;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem10();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem11_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 70600674;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem11();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem12_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 76576500;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem12();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem13_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 5537376230;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem13();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem14_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 837799;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem14();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem15_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 137846528820;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem15();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem16_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 1366;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem16();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem17_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 21124;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem17();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem18_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 1074;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem18();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem19_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 171;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem19();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem20_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 648;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem20();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem67_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 7273;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem67();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
