using System.Collections.Generic;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class TriangleNumberHelperTest
    {
        [DataRow(1, 1)]
        [DataRow(2, 3)]
        [DataRow(3, 6)]
        [DataRow(4, 10)]
        [DataRow(5, 15)]
        [DataRow(6, 21)]
        [DataRow(7, 28)]
        [DataRow(8, 36)]
        [DataRow(9, 45)]
        [DataRow(10, 55)]
        [TestMethod]
        public void GetNthTriangleNumber_ReturnsCorrectResult(int n, long nthTriangleNumber)
        {
            TriangleNumberHelper.GetNthTriangleNumber(n).Should().Be(nthTriangleNumber);
        }

        [TestMethod]
        public void GetListOfTriangleNumbersBelowMax_WithMax56_ReturnsCorrectList()
        {
            // Arrange
            var max = 56;
            var expectedResult = new List<long> { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55};

            // Act
            var result = TriangleNumberHelper.GetListOfTriangleNumbersBelowMax(max);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void GetFirstNTriangleNumbersWhichAreAlsoPentagonalAndHexogonal_WithCount2_ReturnsCorrectList()
        {
            // Arrange
            var count = 2;
            var expectedList = new List<long> { 1, 40755 };

            // Act
            var result = TriangleNumberHelper.GetFirstNTriangleNumbersWhichAreAlsoPentagonalAndHexogonal(count);

            // Assert
            result.Should().HaveCount(2);
            result.Should().BeEquivalentTo(expectedList);
        }
    }
}
