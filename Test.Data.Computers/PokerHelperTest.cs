using Data.Computers;
using Data.Computers.TestData;
using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class PokerHelperTest
    {
        [TestMethod]
        public void ComputeWinner_ForExampleData_ReturnsCorrectResult()
        {
            // Arrange
            var testPokerHands = TestData.ExamplePokerHandsProblem54();

            // Act
            var result1 = PokerHelper.ComputeWinner(testPokerHands.Item1[0], testPokerHands.Item2[0]);
            var result2 = PokerHelper.ComputeWinner(testPokerHands.Item1[1], testPokerHands.Item2[1]);
            var result3 = PokerHelper.ComputeWinner(testPokerHands.Item1[2], testPokerHands.Item2[2]);
            var result4 = PokerHelper.ComputeWinner(testPokerHands.Item1[3], testPokerHands.Item2[3]);
            var result5 = PokerHelper.ComputeWinner(testPokerHands.Item1[4], testPokerHands.Item2[4]);

            // Assert
            using (new AssertionScope())
            {
                result1.Should().Be(2);
                result2.Should().Be(1);
                result3.Should().Be(2);
                result4.Should().Be(1);
                result5.Should().Be(1);
            }
        }
    }
}
