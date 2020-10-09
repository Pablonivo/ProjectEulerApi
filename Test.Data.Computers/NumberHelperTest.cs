using System;
using System.Collections.Generic;
using System.Linq;
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
        public void GetMultiplesOfNumberBelowMax_WhenAskedForMultiplesOf3Below10_ReturnsCorrectList()
        {
            // Arrange
            var number = 3;
            var max = 10;
            var expectedResult = new List<int> { 3, 6, 9 };

            // Act
            var result = NumberHelper.GetMultiplesOfNumberBelowMax(number, max);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void GetSmallestMultiple_WhenAskedForSmallestMultipleOfIntegersFrom1To10_ReturnsCorrectList()
        {
            // Arrange
            var numberList = Enumerable.Range(1, 10).ToList();
            var expectedResult = 2520;

            // Act
            var result = NumberHelper.GetSmallestMultiple(numberList);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetLargestProductOfAdjacentNumbersInString_AGridWith1000Digits_ReturnsCorrectResult()
        {
            // Arrange
            var testData = TestData.Get1000digitNumberProblem8();
            var numberOfAdjacentDigits = 4;
            var expectedResult = 5832;

            // Act
            var result = NumberHelper.GetLargestProductOfAdjacentNumbersInString(testData, numberOfAdjacentDigits);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void IsPythagoreanTriplet_IfCalledWith3And4And5_ReturnsTrue()
        {
            // Arrange & Act
            var result = NumberHelper.IsPythagoreanTriplet(3, 4, 5);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void GetPythagoreanTripletForWhichSumEquals_WhenSumIs12_ReturnsCorrectTriplet()
        {
            // Arrange
            var sum = 12;
            var expectedResult = (3, 4, 5);

            // Act 
            var result = NumberHelper.GetPythagoreanTripletForWhichSumEquals(sum);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void Factorial_Of5_Returns120()
        {
            // Arrange
            var n = 5;
            var expectedResult = 120;

            // Act
            var result = NumberHelper.Factorial(n);

            // Assert
            result.Should().Be(expectedResult);
        }

        public void BinominalCoefficient_Of4Over2_Returns6()
        {
            // Arrange
            var n = 4;
            var k = 2;
            var expectedResult = 6;

            // Act
            var result = NumberHelper.BinominalCoefficient(n, k);

            // Assert
            result.Should().Be(expectedResult);
        }

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
    }
}
