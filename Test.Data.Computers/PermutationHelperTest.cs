using System.Collections.Generic;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class PermutationHelperTest
    {
        [TestMethod]
        public void GetListOfAllPossiblePermutations_WithNumbers123_ReturnsCorrectList()
        {
            // Arrange
            var characters = new List<char> { '1', '2', '3' };

            // Act
            var result = PermutationHelper.GetListOfAllPossiblePermutations(characters);

            // Assert
            result.Should().HaveCount(6);
            result.Should().Contain("231");
        }
    }
}
