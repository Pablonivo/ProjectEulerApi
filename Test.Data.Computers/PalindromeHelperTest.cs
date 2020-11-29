using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class PalindromeHelperTest
    {
        [TestMethod]
        [DataRow(9, true)]
        [DataRow(18, false)]
        [DataRow(232, true)]
        [DataRow(3773, true)]
        [DataRow(12322, false)]
        public void IsPalindrome_ReturnsCorrectResult(int number, bool expectedResult)
        {
            PalindromeHelper.IsPalindrome(number).Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow(585, true)]
        public void IsPalindromeInBase2_ReturnsCorrectResult(int number, bool expectedResult)
        {
            PalindromeHelper.IsPalindromeInBase2(number).Should().Be(expectedResult);
        }
    }
}
