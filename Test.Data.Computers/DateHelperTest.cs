using System;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class DateHelperTest
    {
        [TestMethod]
        public void NumberOfSundaysOnTheFirstOfTheMonth_ForYear2020_ReturnsCorrectResult()
        {
            // Arrange
            var startDate = new DateTime(2020, 1, 1);
            var endDate = new DateTime(2020, 12, 31);
            var numberOfSundaysOnFirstDayOfMonth = 2;

            // Act
            var result = DateHelper.NumberOfSundaysOnTheFirstOfTheMonth(startDate, endDate);

            // Assert
            result.Should().Be(numberOfSundaysOnFirstDayOfMonth);
        }
    }
}
