using Data.Computers.Solutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class Problem0008Test
    {
        [TestMethod]
        public void ComputeSolutionProblem8_With4AdjacentDigits_Returns5832()
        {
            var numberOfAdjacentDigits = 4;
            var expectedResult = 5832;

            var result = new Problem0008(numberOfAdjacentDigits).ComputeSolution();

            result.Should().Be(expectedResult);
        }
    }
}