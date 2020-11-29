using System.Collections.Generic;
using System.Numerics;
using Data.Computers;
using Data.Computers.TestData;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class NumberHelperTest
    {
        [TestMethod]
        public void SumOfDigits_Of32768_Returns26()
        {
            // Arrange
            var n = 32768;
            var expectedResult = 26;

            // Act
            var result = NumberHelper.SumOfDigits(n);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void SumOfSquaresOfDigits_Of145_Returns42()
        {
            // Arrange
            var n = 145;
            var expectedResult = 42;

            // Act
            var result = NumberHelper.SumOfSquaresOfDigits(n);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void NumberOfDigits_Of145_Returns3()
        {
            // Arrange
            var n = 145;
            var expectedResult = 3;

            // Act
            var result = NumberHelper.NumberOfDigits(n);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void MaximalPathOfNumberTriangle_OfExampleTriangle_ReturnsCorrectResult()
        {
            // Arrange
            var exampleTriangle = TestData.ExampleTriangleProblem18();
            var expectedResult = 23;

            // Act
            var result = NumberHelper.MaximalPathOfNumberTriangle(exampleTriangle);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetSumOfDiagonalsNumberSpiral_For5Times5Spiral_ReturnsCorrectResult()
        {
            // Arrange
            var sizeOfSpiralSides = 5;
            var expectedResult = 101;

            // Act
            var result = NumberHelper.GetSumOfDiagonalsNumberSpiral(sizeOfSpiralSides);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetLengthOfNumberSpiralForWhichPercentageOfPrimesOnDiagonalsIsLowerThanLimit_For63Percent_ReturnsCorrectResult()
        {
            // Arrange
            var desiredUpperBoundPercentagePrimes = 56;
            var expectedResult = 5;

            // Act
            var result = NumberHelper.GetLengthOfNumberSpiralForWhichPercentageOfPrimesOnDiagonalsIsLowerThanLimit(desiredUpperBoundPercentagePrimes);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetListOfDistinctPowers_Max5_ReturnsCorrectList()
        {
            // Arrange
            var maxOfUsedIntegers = 5;

            // Act
            var result = NumberHelper.GetListOfDistinctPowers(maxOfUsedIntegers);

            // Assert
            result.Should().HaveCount(15);
        }

        [TestMethod]
        public void IsIntegerSumOfNthPowerOfDigits_Of1634With4thPowers_ReturnsTrue()
        {
            // Arrange
            var number = 1634;
            var power = 4;

            // Act
            var result = NumberHelper.IsIntegerSumOfNthPowerOfDigits(number, power);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void GetIntegersWhichCanBeWrittenAsNthPowersOfTheirDigits_ForFourthPowers_ReturnsCorrectList()
        {
            // Arrange
            var power = 4;
            var expectedList = new List<long> { 1634, 8208, 9474 };

            // Act
            var result = NumberHelper.GetIntegersWhichCanBeWrittenAsNthPowersOfTheirDigits(power);

            // Assert
            result.Should().BeEquivalentTo(expectedList);
        }

        [TestMethod]
        public void NumberOfWaysToWriteNumberAsSum_For6AndNumbers1And2_ReturnsCorrectResult()
        {
            // Arrange
            var requiredSum = 6;
            var numbersAllowedInSum = new List<int> { 1, 2 };
            var expectedNumberOfWayToWriteNumberAsSum = 4;

            // Act
            var result = NumberHelper.NumberOfWaysToWriteNumberAsSum(requiredSum, numbersAllowedInSum);

            // Assert
            result.Should().Be(expectedNumberOfWayToWriteNumberAsSum);
        }

        [TestMethod]
        public void NumberOfWaysToWriteNumberAsSum_For6AndNumbers1And2And5_ReturnsCorrectResult()
        {
            // Arrange
            var requiredSum = 6;
            var numbersAllowedInSum = new List<int> { 1, 2, 5 };
            var expectedNumberOfWayToWriteNumberAsSum = 5;

            // Act
            var result = NumberHelper.NumberOfWaysToWriteNumberAsSum(requiredSum, numbersAllowedInSum);

            // Assert
            result.Should().Be(expectedNumberOfWayToWriteNumberAsSum);
        }

        [TestMethod]
        public void NumberOfWaysToWriteNumberAsSum_For11AndNumbers1And2And5And10_ReturnsCorrectResult()
        { 
            // Arrange
            var requiredSum = 11;
            var numbersAllowedInSum = new List<int> { 1, 2, 5, 10 };
            var expectedNumberOfWayToWriteNumberAsSum = 12;

            // Act
            var result = NumberHelper.NumberOfWaysToWriteNumberAsSum(requiredSum, numbersAllowedInSum);

            // Assert
            result.Should().Be(expectedNumberOfWayToWriteNumberAsSum);
        }

        [DataRow(9, true)]
        [DataRow(10, false)]
        [DataRow(35, false)]
        [DataRow(36, true)]
        [TestMethod]
        public void IsSquare_ReturnsCorrectResult(int number, bool expectedResult)
        {
            NumberHelper.IsSquare(number).Should().Be(expectedResult);
        }

        [TestMethod]
        public void SumOfFirstNSelfPowers_For10_ReturnsCorrectResult()
        {
            // Arrange
            var n = 10;
            BigInteger expectedResult = 10405071317;
            var numberOfDesiredDigits = 11;

            // Act
            var result = NumberHelper.SumOfFirstNSelfPowersModuloM(n, numberOfDesiredDigits);

            // Assert
            result.Should().Be(expectedResult);
        }

        [DataRow(1487, 4817, true)]
        [DataRow(1177, 1117, false)]
        [TestMethod]
        public void AreNumbersPermutations(int number1, int number2, bool expectedResult)
        {
            NumberHelper.AreNumbersPermutations(number1, number2).Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetArithmeticSequenceFromList_ForAListWithSuchASequence_ReturnsCorrectList()
        {
            // Arrange
            var numberList = new List<long> { 1487, 4817, 6666, 8147 };
            var expectedResult = new List<long> { 1487, 4817, 8147 };

            // Act
            var result = NumberHelper.GetArithmeticSequenceFromList(numberList);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [DataRow(6, 6)]
        [DataRow(47, 74)]
        [DataRow(349, 943)]
        [DataRow(1292, 2921)]
        [DataRow(4213, 3124)]
        [TestMethod]
        public void Reverse_ReturnsCorrectResult(int number, int expectedResult)
        {
            NumberHelper.Reverse(number).Should().Be(expectedResult);
        }

        [DataRow(196, 50, true)]
        [DataRow(47, 1, false)]
        [DataRow(349, 3, false)]
        [DataRow(10677, 53, false)]
        [TestMethod]
        public void IsALynchrelNumberInMaxNumberOfSteps_ReturnsCorrectResult(int number, int maxNumberOfSteps, bool expectedResult)
        {
            NumberHelper.IsALynchrelNumberInMaxNumberOfSteps(number, maxNumberOfSteps).Should().Be(expectedResult);
        }

        [TestMethod]
        public void SmallestCubeWhichHasNCubicPermutations_For3_ReturnsCorrectResult()
        {
            // Arrange
            var number = 3;
            var expectedResult = 41063625;

            // Act
            var result = NumberHelper.SmallestCubeWhichHasNCubicPermutations(number);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
