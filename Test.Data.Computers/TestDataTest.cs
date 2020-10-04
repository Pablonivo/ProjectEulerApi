using Data.Computers.TestData;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class TestDataTest
    {
        [TestMethod]
        public void Get1000digitNumberProblem8_WhenCalled_ReturnsStringWithExpectedLengthOf1000()
        {
            // Arrange
            var expectedLength = 1000;

            // Act
            var result = TestData.Get1000digitNumberProblem8();

            // Assert
            result.Should().HaveLength(expectedLength);
        }
    }
}
