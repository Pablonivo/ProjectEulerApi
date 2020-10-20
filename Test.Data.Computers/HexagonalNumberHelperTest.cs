using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class HexagonalNumberHelperTest
    {
        [TestMethod]
        public void GetNthHexagonalNumber_ForNIs5_ReturnsCorrectHexagonalNumber()
        {
            // Arrange
            var n = 5;
            var expectedHexagonalNumber = 45;

            // Act
            var result = HexagonalNumberHelper.GetNthHexagonalNumber(n);

            // Assert
            result.Should().Be(expectedHexagonalNumber);
        }
    }
}
