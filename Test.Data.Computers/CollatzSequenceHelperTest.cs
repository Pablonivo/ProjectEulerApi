using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class CollatzSequenceHelperTest
    {
        [TestMethod]
        public void GetLengthOfCollatzSequenceForStartingNumber_StartingNumber13_Returns10()
        {
            // Arrange
            var startingNumber = 13;
            var expectedLengthCollactzSequence = 10;

            // Act
            var result = CollatzSequenceHelper.GetLengthOfCollatzSequenceForStartingNumber(startingNumber);

            // Assert
            result.Should().Be(expectedLengthCollactzSequence);
        }

        // 6 -> 3 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1
        // 9 -> 28 -> 14  -> 7 -> 22 -> 11 -> 34 -> 17 -> 52 -> 26 -> 13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1
        [TestMethod]
        public void GetStartingNumberBelowMaxWithLongestSequence_WithMax10_Returns9()
        {
            // Arrange
            var max = 10;
            var expectedResult = 9;

            // Act
            var result = CollatzSequenceHelper.GetStartingNumberBelowMaxWithLongestSequence(max);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
