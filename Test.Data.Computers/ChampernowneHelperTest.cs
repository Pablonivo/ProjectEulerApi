using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class ChampernowneHelperTest
    {
        [DataRow(6, 6)]
        [DataRow(12, 1)]
        [DataRow(189, 9)]
        [DataRow(190, 1)]
        [TestMethod]
        public void GetNthDigitOfChampernownesConstant_ReturnsExpectedResult(int desiredDigit, int expectedResult)
        {
            // Act
            ChampernowneHelper.GetNthDigitOfChampernownesConstant(desiredDigit).Should().Be(expectedResult);
        }
    }
}
