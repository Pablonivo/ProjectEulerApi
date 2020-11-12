using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class ModuloHelperTest
    {
        [DataRow(28, 6, 25, 4)]
        [TestMethod]
        public void ComputeAToThePowerBModuloC_ReturnsCorrectResult(long a, long b, long c, long expectedResult)
        {
            ModuloHelper.ComputeAToThePowerBModuloC(a, b, c).Should().Be(expectedResult);
        }
    }
}
