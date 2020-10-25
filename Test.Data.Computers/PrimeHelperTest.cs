using System.Collections.Generic;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class PrimeHelperTest
    {
        [TestMethod]
        public void GetPrimesFactors_13195_ReturnsExpectedList()
        {
            // Arrange
            var number = 13195;
            var expectedResult = new List<long> { 5, 7, 13, 29 };

            // Act
            var result = PrimeHelper.GetPrimeFactors(number);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void GetPrimeFactorization_18_ReturnsExpectedDictionary()
        {
            // Arrange
            var number = 18;
            var expectedDictionary = new Dictionary<int, int>
            {
                [2] = 1,
                [3] = 2
            };

            // Act
            var result = PrimeHelper.GetPrimeFactorization(number);

            // Assert
            result.Should().BeEquivalentTo(expectedDictionary);
        }

        [DataRow(9, false)]
        [DataRow(17, true)]
        [DataRow(4, false)]
        [DataRow(5, true)]
        [DataRow(3, true)]
        [TestMethod]
        public void IsPrime_ReturnsCorrectResult(int number, bool expectedResult)
        {
            PrimeHelper.IsPrime(number).Should().Be(expectedResult);
        }

        [DataRow(1, 2)]
        [DataRow(2, 3)]
        [DataRow(3, 5)]
        [DataRow(4, 7)]
        [DataRow(5, 11)]
        [DataRow(6, 13)]
        [TestMethod]
        public void GetNthPrime_ReturnsCorrectResult(int number, int expectedResult)
        {
            PrimeHelper.GetNthPrime(number).Should().Be(expectedResult);
        }

        [DataRow(197, true)]
        [DataRow(19, false)]
        [TestMethod]
        public void IsCircularPrime_ReturnsCorrectResult(int number, bool expectedResult)
        {
            PrimeHelper.IsCircularPrime(number).Should().Be(expectedResult);
        }

        [DataRow(3797, true)]
        [DataRow(19, false)]
        [TestMethod]
        public void IsTruncatablePrime_ReturnsCorrectResult(int number, bool expectedResult)
        {
            PrimeHelper.IsTruncatablePrime(number).Should().Be(expectedResult);
        }

        [TestMethod]
        public void SieveOfEratosthenes_10_ReturnsExpectedListOfPrimes()
        {
            // Arrange
            var max = 10;
            var expectedListOfPrimes = new List<int> { 2, 3, 5, 7 };

            // Act
            var result = PrimeHelper.SieveOfEratosthenes(max);

            // Result
            result.Should().BeEquivalentTo(expectedListOfPrimes);
        }

        [TestMethod]
        public void GetListOfCircularPrimesBelowMax_WithMax100_ReturnsExpectedListOfCircularPrimes()
        {
            // Arrange
            var max = 100;
            var expectedListOfPrimes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, 97 };

            // Act
            var result = PrimeHelper.GetListOfCircularPrimesBelowMax(max);

            // Result
            result.Should().BeEquivalentTo(expectedListOfPrimes);
        }

        [TestMethod]
        public void GetAllTruncatablePrimes_WhenCalled_ReturnsExpectedNumberOfPrimes()
        {
            // Arrange
            var expectedNumberOfTruncatablePrimes = 11;

            // Act
            var result = PrimeHelper.GetAllTruncatablePrimes();

            // Result
            result.Should().HaveCount(expectedNumberOfTruncatablePrimes);
        }

        [DataRow(9, true)]
        [DataRow(15, true)]
        [DataRow(21, true)]
        [DataRow(25, true)]
        [DataRow(27, true)]
        [DataRow(33, true)]
        [TestMethod]
        public void CanBeWrittenAsSumOfPrimeAndTwiceASquare_ReturnsCorrectResult(int number, bool expectedResult)
        {
            PrimeHelper.CanBeWrittenAsSumOfPrimeAndTwiceASquare(number).Should().Be(expectedResult);
        }

        [DataRow(2, 2, 14)]
        [DataRow(3, 3, 644)]
        [TestMethod]
        public void GetFirstNumberOfConsecutiveNumbersToHaveMDistinctPrimeFactors_ReturnsCorrectResult(int count, int distintPrimeFactors, long expectedResult)
        {
            PrimeHelper.GetFirstNumberOfConsecutiveNumbersToHaveMDistinctPrimeFactors(count, distintPrimeFactors).Should().Be(expectedResult);
        }

        [DataRow(100, 41)]
        [DataRow(1000, 953)]
        [TestMethod]
        public void PrimeBelowMaxWhichCanBeWrittenAsSumOfMostConsectivePrimes_ReturnsCorrectResult(int max, int expectedPrime)
        {
            PrimeHelper.PrimeBelowMaxWhichCanBeWrittenAsSumOfMostConsectivePrimes(max).Should().Be(expectedPrime);
        }

        [TestMethod]
        public void PrimesInFamilyByReplacingDigitsBySameNumber_ForFirstDigitOf13_ReturnsCorrectList()
        {
            // Arrange
            var number = 13;
            var digitsToReplace = new List<int> { 1 };
            var expectedPrimesInFamily = new List<long> { 13, 23, 43, 53, 73, 83 };

            // Act
            var result = PrimeHelper.PrimesInFamilyByReplacingDigitsBySameNumber(number, digitsToReplace);

            // Result
            result.Should().BeEquivalentTo(expectedPrimesInFamily);
        }

        [TestMethod]
        public void PrimesInFamilyByReplacingDigitsBySameNumber_For3thAnd4thDigitsOf56003_ReturnsCorrectList()
        {
            // Arrange
            var number = 56003;
            var digitsToReplace = new List<int> { 3, 4 };
            var expectedPrimesInFamily = new List<long> { 56003, 56113, 56333, 56443, 56663, 56773, 56993 };

            // Act
            var result = PrimeHelper.PrimesInFamilyByReplacingDigitsBySameNumber(number, digitsToReplace);

            // Result
            result.Should().BeEquivalentTo(expectedPrimesInFamily);
        }

        [TestMethod]
        public void MaximumSizeOfFamilyByReplacingSomeDigitsBySameNumber_Of56003_Returns7()
        {
            // Arrange
            var number = 56003;
            var expectedMaximumSizeOfFamily = 7;

            // Act
            var result = PrimeHelper.MaximumSizeOfFamilyByReplacingSomeDigitsBySameNumber(number);

            // Result
            result.Should().Be(expectedMaximumSizeOfFamily);
        }

        [DataRow(6, 13)]
        [DataRow(7, 56003)]
        [TestMethod]
        public void FirstPrimeWhichHasDesiredSizeOfFamilyByReplacingSomeDigitsBySameNumber_ReturnsCorrectResult(int desiredSizeOfFamily, long expectedPrime)
        {
            PrimeHelper.FirstPrimeWhichHasDesiredSizeOfFamilyByReplacingSomeDigitsBySameNumber(desiredSizeOfFamily).Should().Be(expectedPrime);
        }
    }
}
