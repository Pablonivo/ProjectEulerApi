using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class PentagonNumberHelperTest
    {
        [TestMethod]
        public void GetNthPentagonNumber_ForNIs10_ReturnsCorrectPentagonNumber()
        {
            // Arrange
            var n = 10;
            var expectedPentagonNumber = 145;

            // Act
            var result = PentagonNumberHelper.GetNthPentagonalNumber(n);

            // Assert
            result.Should().Be(expectedPentagonNumber);
        }

        [DataRow(92, true)]
        [DataRow(48, false)]
        [TestMethod]
        public void IsPentagonNumber_ReturnsCorrectResult(int number, bool expectedResult)
        {
            PentagonNumberHelper.IsPentagonalNumber(number).Should().Be(expectedResult);
        }
    }
}
