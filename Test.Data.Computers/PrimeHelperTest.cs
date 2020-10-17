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

        [TestMethod]
        public void GetListOfPrimesUpTo_10_ReturnsExpectedListOfPrimes()
        {
            // Arrange
            var max = 10;
            var expectedListOfPrimes = new List<int> { 2, 3, 5, 7 };

            // Act
            var result = PrimeHelper.GetListOfPrimesUpTo(max);

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
    }
}
