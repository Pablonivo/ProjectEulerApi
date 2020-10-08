using System.Collections.Generic;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class NumberToWordHelperTest
    {
        [DataRow(317, "threehundredandseventeen")]
        [DataRow(342, "threehundredandfortytwo")]
        [DataRow(445, "fourhundredandfortyfive")]
        [DataRow(999, "ninehundredandninetynine")]
        [TestMethod]
        public void ToEnglishWord_ReturnsExpectedResult(int number, string numberInEnglishWords)
        {
            NumberToWordHelper.ToEnglishWord(number).Should().Be(numberInEnglishWords);
        }

        [TestMethod]
        public void SumOfLengthOfNumbersAsWordsWrittenOut_NumbersFrom1To5_Returns19()
        {
            // Arrange
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var expectedResult = 19;

            // Act
            var result = NumberToWordHelper.SumOfLengthOfNumbersAsWordsWrittenOut(numbers);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
