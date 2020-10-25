using System.Collections.Generic;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class SubsetHelperTest
    {
        [TestMethod]
        public void AllSubsets_ForListWithNumbers1And2_ReturnsCorrectSubsets()
        {
            // Arrange
            var list = new List<int> { 1, 2 };
            var expectedResult = new List<List<int>> { new List<int>(), new List<int> { 1 }, new List<int> { 2 }, new List<int> { 1, 2 } };

            // Act
            var result = SubsetHelper.AllSubsets(list);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void AllStrictSubsets_ForListWithNumbers1And2_ReturnsCorrectSubsets()
        {
            // Arrange
            var list = new List<int> { 1, 2 };
            var expectedResult = new List<List<int>> { new List<int> { 1 }, new List<int> { 2 }};

            // Act
            var result = SubsetHelper.AllStrictSubsets(list);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
