using Data.Computers.Solutions;
using Data.Computers.TestData;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class Problem0018Test
    {
        [TestMethod]
        public void ComputeSolutionProblem18_ExampleTriangle_Returns23()
        {
            var exampleTriangle = TestData.ExampleTriangleProblem18();
            var expectedResult = 23;

            var result = new Problem0018(exampleTriangle).ComputeSolution();

            result.Should().Be(expectedResult);
        }
    }
}