using System.Collections.Generic;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class AbundantNumberHelperTest
    {
        [DataRow(12, true)]
        [DataRow(28, false)]
        [TestMethod]
        public void IsAbundantNumber_ReturnsCorrectResult(int number, bool isAbundant)
        {
            AbundantNumberHelper.IsAbundantNumber(number).Should().Be(isAbundant);
        }

        [TestMethod]
        public void GetListOfAbundantNumberBelowMax_For24_ReturnsCorrectList()
        {
            // Arrange
            var max = 24;
            var listOfAbundantNumbersBelowMax = new List<int> { 12, 18, 20 };

            // Act
            var result = AbundantNumberHelper.GetListOfAbundantNumberBelowMax(max);

            // Assert
            result.Should().BeEquivalentTo(listOfAbundantNumbersBelowMax);
        }
    }
}
