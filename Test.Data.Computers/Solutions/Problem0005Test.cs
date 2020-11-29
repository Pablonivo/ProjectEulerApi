using Data.Computers.Solutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class Problem0005Test
    {
        [TestMethod]
        public void ComputeSolutionProblem5_WithUpperBound10_Returns2520()
        {
            var upperBound = 10;
            var expectedResult = 2520;

            var result = new Problem0005(upperBound).ComputeSolution();

            result.Should().Be(expectedResult);
        }
    }
}