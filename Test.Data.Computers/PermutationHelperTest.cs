using System.Collections.Generic;
using System.Numerics;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class PermutationHelperTest
    {
        [TestMethod]
        public void ListOfNumbersWithIncreasingDigits_WithNumbers0To2And3Digits_ReturnsCorrectResult()
        {
            // Arrange
            var characters = new List<char> { '0', '1', '2' };
            var numberOfDigits = 3;
            var expectedResult = new List<string>
            {
                "000",
                "001",
                "002",
                "011",
                "012",
                "022",
                "111",
                "112",
                "122",
                "222"
            };

            // Act
            var result = PermutationHelper.ListOfNumbersWithIncreasingDigits(numberOfDigits, characters);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void NumberOfPermutations_For022_Returns3()
        {
            // Arrange
            var number = "022";
            var expectedResult = 3;

            // Act
            var result = PermutationHelper.NumberOfPermutations(number);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
