using Data.Computers.Solutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class Problem0012Test
    {
        [TestMethod]
        public void ComputeSolutionProblem12_WithLowerBound5Digits_Returns28()
        {
            var lowerBoundNumberOfDivisors = 5;
            var expectedResult = 28;

            var result = new Problem0012(lowerBoundNumberOfDivisors).ComputeSolution();

            result.Should().Be(expectedResult);
        }
    }
}