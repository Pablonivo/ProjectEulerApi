using Data.Computers.Solutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class Problem0004Test
    {
        [TestMethod]
        public void ComputeSolutionProblem4_With2DigitsNumbers_Returns9009()
        {
            var numberOfDigits = 2;
            var expectedResult = 9009;

            var result = new Problem0004(numberOfDigits).ComputeSolution();

            result.Should().Be(expectedResult);
        }
    }
}
