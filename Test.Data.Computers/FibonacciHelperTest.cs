﻿using System.Collections.Generic;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class FibonacciHelperTest
    {
        [TestMethod]
        public void GetFibonacciListBelowMax_WhenAskedForFibonacciListBelow90_ReturnsCorrectList()
        {
            // Arrange
            var max = 90;
            var expectedResult = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

            // Act
            var result = FibonacciHelper.GetFibonacciListBelowMax(max);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void GetIndexOfFirstFibonacciNumberWithAtLeastNDigits_AtLeast3Digits_Returns12()
        {
            // Arrange
            var requiredNumberOfDigits = 3;
            var indexOfFirstFibonacciNumberWith3Digits = 12; 

            // Act
            var result = FibonacciHelper.GetIndexOfFirstFibonacciNumberWithAtLeastNDigits(requiredNumberOfDigits);

            // Assert
            result.Should().Be(indexOfFirstFibonacciNumberWith3Digits);
        }
    }
}
