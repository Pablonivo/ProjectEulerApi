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
        public void GetSolutionOfProblem21_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 31626;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem21();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem22_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 871198282;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem22();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem23_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 4179871;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem23();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem24_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 2783915460;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem24();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem25_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 4782;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem25();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem26_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 983;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem26();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem27_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = -59231;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem27();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem28_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 669171001;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem28();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem29_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 9183;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem29();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem30_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 443839;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem30();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem31_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 73682;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem31();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem32_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 45228;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem32();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem33_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 100;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem33();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem34_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 40730;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem34();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem35_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 55;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem35();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem36_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 872187;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem36();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem37_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 748317;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem37();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem38_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 932718654;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem38();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem39_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 840;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem39();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem40_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 210;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem40();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem41_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 7652413;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem41();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem42_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 162;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem42();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem43_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 16695334890;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem43();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem44_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 5482660;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem44();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem45_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 1533776805;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem45();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem46_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 5777;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem46();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem47_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 134043;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem47();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem48_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 9110846700;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem48();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem49_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 296962999629;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem49();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem50_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 997651;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem50();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem51_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 121313;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem51();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem52_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 142857;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem52();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSolutionOfProblem53_WhenCalled_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 4075;

            // Act
            var result = SolutionComputer.GetSolutionOfProblem53();

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
