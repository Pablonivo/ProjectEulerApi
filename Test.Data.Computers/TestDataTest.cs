using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Data.Computers.TestData;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Data.Computers
{
    [TestClass]
    public class TestDataTest
    {
        [TestMethod]
        public void Get1000digitNumberProblem8_WhenCalled_ReturnsStringWithExpectedLengthOf1000()
        {
            // Arrange
            var expectedLength = 1000;

            // Act
            var result = TestData.Get1000digitNumberProblem8();

            // Assert
            result.Should().HaveLength(expectedLength);
        }

        [TestMethod]
        public void Get20By20GridProblem11_WhenCalled_ReturnsGridOf400Numbers()
        {
            // Arrange
            var expectedNumberOfIntegers = 20 * 20;

            // Act
            var result = TestData.Get20By20GridProblem11();

            // Assert
            result.Should().HaveCount(expectedNumberOfIntegers);
            result.Should().AllBeOfType(typeof(int));
        }

        [TestMethod]
        public void Get100NumbersWith50DigitsProblem13_WhenCalled_Returns100NumbersWith50Digits()
        {
            // Arrange
            var expectedNumberOfIntegers = 100;
            var expectedNumberOfDigitsPerInteger = 50;

            // Act
            var result = TestData.Get100NumbersWith50DigitsProblem13();

            // Assert
            result.Should().HaveCount(expectedNumberOfIntegers);
            foreach(BigInteger integer in result)
            {
                integer.ToString().Length.Should().Be(expectedNumberOfDigitsPerInteger);
            }
        }

        [TestMethod]
        public void ExampleTriangleProblem18_WhenCalled_ReturnsExampleTriangle()
        {
            // Arrange
            var numberOfRows = 4;
            var expectedNumberLeftBottom = 8;
            var expectedNumberRightBottom = 3;

            // Act
            var result = TestData.ExampleTriangleProblem18();

            // Assert
            result[numberOfRows - 1, 0].Should().Be(expectedNumberLeftBottom);
            result[numberOfRows - 1, numberOfRows - 1].Should().Be(expectedNumberRightBottom);
        }

        [TestMethod]
        public void TriangleProblem18_WhenCalled_ReturnsExpectedTriangle()
        {
            // Arrange
            var numberOfRows = 15;
            var expectedNumberLeftBottom = 4;
            var expectedNumberRightBottom = 23;

            // Act
            var result = TestData.TriangleProblem18();

            // Assert
            result[numberOfRows - 1, 0].Should().Be(expectedNumberLeftBottom);
            result[numberOfRows - 1, numberOfRows - 1].Should().Be(expectedNumberRightBottom);
        }

        [TestMethod]
        public void TriangleProblem67_WhenCalled_ReturnsExpectedTriangle()
        {
            // Arrange
            var numberOfRows = 100;
            var expectedNumberLeftBottom = 23;
            var expectedNumberRightBottom = 35;

            // Act
            var result = TestData.TriangleProblem67();

            // Assert
            result[numberOfRows - 1, 0].Should().Be(expectedNumberLeftBottom);
            result[numberOfRows - 1, numberOfRows - 1].Should().Be(expectedNumberRightBottom);
        }

        [TestMethod]
        public void FirstNamesProblem22_WhenCalled_ReturnsListWithNames()
        {
            // Arrange
            var expectedNumberOfNames = 5163;
            var firstName = "MARY";
            var lastname = "ALONSO";

            // Act
            var result = TestData.FirstNamesProblem22();

            // Assert
            result.Count.Should().Be(expectedNumberOfNames);
            result.First().Should().Be(firstName);
            result.Last().Should().Be(lastname);
        }

        [TestMethod]
        public void EnglishWordsProblem42_WhenCalled_ReturnsListWithWords()
        {
            // Arrange
            var expectedNumberOfWords = 1786;
            var firstWord = "A";
            var lastWord = "YOUTH";

            // Act
            var result = TestData.EnglishWordsProblem42();

            // Assert
            result.Count.Should().Be(expectedNumberOfWords);
            result.First().Should().Be(firstWord);
            result.Last().Should().Be(lastWord);
        }

        [TestMethod]
        public void PokerHandsProblem54_WhenCalled_ReturnsListOfPokerHands()
        {
            // Arrange
            var expectedNumberOfPokerHands = 1000;
            var lastHandOfSecondPlayer = new List<string> { "7C", "8C", "5C", "QD", "6C" };

            // Act
            var result = TestData.PokerHandsProblem54();

            // Assert
            result.Item1.Should().HaveCount(expectedNumberOfPokerHands);
            result.Item2.Should().HaveCount(expectedNumberOfPokerHands);
            result.Item2.Last().Should().BeEquivalentTo(lastHandOfSecondPlayer);
        }

        [TestMethod]
        public void ExamplePokerHandsProblem54_WhenCalled_ReturnsListOfPokerHands()
        {
            // Arrange
            var expectedNumberOfPokerHands = 5;
            var lastHandOfSecondPlayer = new List<string> { "3C", "3D", "3S", "9S", "9D" };

            // Act
            var result = TestData.ExamplePokerHandsProblem54();

            // Assert
            result.Item1.Should().HaveCount(expectedNumberOfPokerHands);
            result.Item2.Should().HaveCount(expectedNumberOfPokerHands);
            result.Item2.Last().Should().BeEquivalentTo(lastHandOfSecondPlayer);
        }
    }
}
