using System;
using Data.Computers.Solutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class Problem0019Test
    {
        [TestMethod]
        public void ComputeSolutionProblem19_ForYear2020_ReturnsCorrectResult()
        {
            var startDate = new DateTime(2020, 1, 1);
            var endDate = new DateTime(2020, 12, 31);
            var numberOfSundaysOnFirstDayOfMonth = 2;

            // Act
            var result = new Problem0019(startDate, endDate).ComputeSolution();

            // Assert
            result.Should().Be(numberOfSundaysOnFirstDayOfMonth);
        }
    }
}