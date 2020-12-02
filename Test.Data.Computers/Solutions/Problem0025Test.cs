using System;
using Data.Computers.Solutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class Problem0025Test
    {
        [TestMethod]
        public void ComputeSolutionProblem25_AtLeast3Digits_Returns12()
        {
            // Arrange
            var requiredNumberOfDigits = 3;
            var indexOfFirstFibonacciNumberWith3Digits = 12;

            // Act
            var result = new Problem0025(requiredNumberOfDigits).ComputeSolution();

            // Assert
            result.Should().Be(indexOfFirstFibonacciNumberWith3Digits);
        }
    }
}