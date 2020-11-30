using System.Collections.Generic;
using Data.Computers.Solutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class Problem0017Test
    {
        [TestMethod]
        public void ComputeSolutionProblem17_NumbersFrom1To5_Returns19()
        {
            var upperBound = 5;
            var expectedResult = 19;

            var result = new Problem0017(upperBound).ComputeSolution();

            result.Should().Be(expectedResult);
        }
    }
}