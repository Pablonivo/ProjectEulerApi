using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class InfiniteContinuedFractionHelperTest
    {
        [TestMethod]
        public void FirstNIterationOfSquareRootOfTwo_ForNEqualTo8_ReturnsCorrectResult()
        {
            var n = 8;
            var result = InfiniteContinuedFractionHelper.FirstNIterationOfSquareRootOfTwo(n);

            using (new AssertionScope())
            {
                result[0].Numerator.Should().Be(3);
                result[0].Denominator.Should().Be(2);

                result[1].Numerator.Should().Be(7);
                result[1].Denominator.Should().Be(5);

                result[2].Numerator.Should().Be(17);
                result[2].Denominator.Should().Be(12);

                result[3].Numerator.Should().Be(41);
                result[3].Denominator.Should().Be(29);

                result[4].Numerator.Should().Be(99);
                result[4].Denominator.Should().Be(70);

                result[5].Numerator.Should().Be(239);
                result[5].Denominator.Should().Be(169);

                result[6].Numerator.Should().Be(577);
                result[6].Denominator.Should().Be(408);

                result[7].Numerator.Should().Be(1393);
                result[7].Denominator.Should().Be(985);
            }
        }
    }
}
