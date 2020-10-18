using Data.Computers.DataFiles;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class TestDataHelperTest
    {
        [TestMethod]
        public void GetNameScore_OfCOLIN_Returns53()
        {
            // Arrange
            var name = "COLIN";
            var expectedValue = 53;

            // Act
            var result = TestDataHelper.GetWordScore(name);

            // Assert
            result.Should().Be(expectedValue);
        }
    }
}
