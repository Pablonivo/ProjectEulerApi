using System.Collections.Generic;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class FibonacciHelperTest
    {
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
