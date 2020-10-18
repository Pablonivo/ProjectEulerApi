using System.Collections.Generic;
using System.Linq;
using Data.Computers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class PythagoreanTripletHelperTest
    {
        [TestMethod]
        public void IsPythagoreanTriplet_IfCalledWith3And4And5_ReturnsTrue()
        {
            // Arrange & Act
            var result = PythagoreanTripletHelper.IsPythagoreanTriplet(3, 4, 5);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void GetPythagoreanTripletForWhichSumEquals_WhenSumIs12_ReturnsCorrectTriplet()
        {
            // Arrange
            var sum = 12;
            var expectedResult = (3, 4, 5);

            // Act 
            var result = PythagoreanTripletHelper.GetPythagoreanTripletForWhichSumEquals(sum);

            // Assert
            result.Should().HaveCount(1);
            result.Single().Should().Be(expectedResult);
        }

        [TestMethod]
        public void GetPythagoreanTripletForWhichSumEquals_WhenSumIs120_ReturnsCorrectThreeTriplet()
        {
            // Arrange
            var sum = 120;
            var expectedResult = new List<(int, int, int)> { (20, 48, 52), (24, 45, 51), (30, 40, 50) };

            // Act 
            var result = PythagoreanTripletHelper.GetPythagoreanTripletForWhichSumEquals(sum);

            // Assert
            result.Should().HaveCount(3);
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
