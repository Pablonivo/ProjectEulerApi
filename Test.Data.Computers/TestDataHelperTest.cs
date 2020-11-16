using System.Text;
using Data.Computers.DataFiles;
using Data.Computers.TestData;
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

        [TestMethod]
        public void DecryptTextProblem59_Problem59Text_ReturnsCorrectResult()
        {
            // Arrange
            var asciiValues = TestData.CipherTextProblem59();
            var expectedWordInText = "Euler";

            // Act
            var result = TestDataHelper.DecryptTextProblem59(asciiValues);

            // Assert
            Encoding.ASCII.GetString(result.ToArray()).Should().Contain(expectedWordInText);
        }
    }
}
