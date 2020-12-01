using Data.Computers.Solutions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers.Solutions
{
    [TestClass]
    public class SolutionsTest
    {
        [TestMethod]
        public void ComputeSolution_ForProblem0001_ReturnsSolution()
        {
            new Problem0001().ComputeSolution().Should().Be(233168);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0002_ReturnsSolution()
        {
            new Problem0002().ComputeSolution().Should().Be(4613732);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0003_ReturnsSolution()
        {
            new Problem0003().ComputeSolution().Should().Be(6857);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0004_ReturnsSolution()
        {
            new Problem0004().ComputeSolution().Should().Be(906609);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0005_ReturnsSolution()
        {
            new Problem0005().ComputeSolution().Should().Be(232792560);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0006_ReturnsSolution()
        {
            new Problem0006().ComputeSolution().Should().Be(25164150);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0007_ReturnsSolution()
        {
            new Problem0007().ComputeSolution().Should().Be(104743);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0008_ReturnsSolution()
        {
            new Problem0008().ComputeSolution().Should().Be(23514624000);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0009_ReturnsSolution()
        {
            new Problem0009().ComputeSolution().Should().Be(31875000);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0010_ReturnsSolution()
        {
            new Problem0010().ComputeSolution().Should().Be(142913828922);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0011_ReturnsSolution()
        {
            new Problem0011().ComputeSolution().Should().Be(70600674);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0012_ReturnsSolution()
        {
            new Problem0012().ComputeSolution().Should().Be(76576500);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0013_ReturnsSolution()
        {
            new Problem0013().ComputeSolution().Should().Be(5537376230);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0014_ReturnsSolution()
        {
            new Problem0014().ComputeSolution().Should().Be(837799);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0015_ReturnsSolution()
        {
            new Problem0015().ComputeSolution().Should().Be(137846528820);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0016_ReturnsSolution()
        {
            new Problem0016().ComputeSolution().Should().Be(1366);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0017_ReturnsSolution()
        {
            new Problem0017().ComputeSolution().Should().Be(21124);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0018_ReturnsSolution()
        {
            new Problem0018().ComputeSolution().Should().Be(1074);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0019_ReturnsSolution()
        {
            new Problem0019().ComputeSolution().Should().Be(171);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0020_ReturnsSolution()
        {
            new Problem0020().ComputeSolution().Should().Be(648);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0021_ReturnsSolution()
        {
            new Problem0021().ComputeSolution().Should().Be(31626);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0022_ReturnsSolution()
        {
            new Problem0022().ComputeSolution().Should().Be(871198282);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0023_ReturnsSolution()
        {
            new Problem0023().ComputeSolution().Should().Be(4179871);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0024_ReturnsSolution()
        {
            new Problem0024().ComputeSolution().Should().Be(2783915460);
        }

        [TestMethod]
        public void ComputeSolution_ForProblem0067_ReturnsSolution()
        {
            new Problem0067().ComputeSolution().Should().Be(7273);
        }
    }
}