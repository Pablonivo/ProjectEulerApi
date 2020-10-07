using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class DivisorHelperTest
    {
        [DataRow(1, 1)]
        [DataRow(3, 2)]
        [DataRow(6, 4)]
        [DataRow(10, 4)]
        [DataRow(15, 4)]
        [DataRow(21, 4)]
        [DataRow(28, 6)]
        [TestMethod]
        public void GetNumberOfDivisors_ReturnsCorrectResult(long n, int numberOfDivisors)
        {
            DivisorHelper.GetNumberOfDivisors(n).Should().Be(numberOfDivisors);
        }
    }
}
