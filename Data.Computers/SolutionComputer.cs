using System;
using System.Linq;
using System.Numerics;
using Data.Computers.DataFiles;

namespace Data.Computers
{
    public static class SolutionComputer
    {
        public static int GetSolutionOfProblem1()
        {
            var max = 1000;
            var multiplesOfThree = NumberHelper.GetMultiplesOfNumberBelowMax(3, max);
            var multiplesOfFive = NumberHelper.GetMultiplesOfNumberBelowMax(5, max);

            var multiplesOfThreeAndFiveBelowMax = multiplesOfThree.Union(multiplesOfFive);

            return multiplesOfThreeAndFiveBelowMax.Sum();
        }

        public static int GetSolutionOfProblem2()
        {
            var max = 4000000;
            return FibonacciHelper.GetFibonacciListBelowMax(max).Where(x => x % 2 == 0).Sum();
        }

        public static long GetSolutionOfProblem3()
        {
            var max = 600851475143;
            return PrimeHelper.GetPrimeFactors(max).Max();
        }

        public static long GetSolutionOfProblem4()
        {
            var max = 1000;
            return PalindromeHelper.GetLargestPalindromeOfProductOfTwoNumbersBelowMax(max);
        }

        public static long GetSolutionOfProblem5()
        {
            var numberFrom1To20 = Enumerable.Range(1, 20).ToList();
            return NumberHelper.GetSmallestMultiple(numberFrom1To20);
        }

        public static long GetSolutionOfProblem6()
        {
            var number = 100;
            var sumOfSquares = (long)Enumerable.Range(1, number).Select(x => x * x).Sum();
            var squareOfSum = (long)Math.Pow(Enumerable.Range(1, number).Sum(), 2);

            return squareOfSum - sumOfSquares;
        }

        public static long GetSolutionOfProblem7()
        {
            var number = 10001;
            return PrimeHelper.GetNthPrime(number);
        }

        public static long GetSolutionOfProblem8()
        {
            var testData = TestData.TestData.Get1000digitNumberProblem8();
            var numberOfAdjacentDigits = 13;

            return NumberHelper.GetLargestProductOfAdjacentNumbersInString(testData, numberOfAdjacentDigits);
        }

        public static long GetSolutionOfProblem9()
        {
            var sum = 1000;
            var (a, b, c) =  NumberHelper.GetPythagoreanTripletForWhichSumEquals(sum);
            return a * b * c;
        }

        public static long GetSolutionOfProblem10()
        {
            var max = 2000000;
            return PrimeHelper.GetListOfPrimesUpTo(max).Sum();
        }

        public static long GetSolutionOfProblem11()
        {
            var grid = TestData.TestData.Get20By20GridProblem11();
            return NumberHelper.GetLargestProductOf4AdjacentNumberInGrid(grid);
        }

        public static long GetSolutionOfProblem12()
        {
            var numberOfDivisors = 500;
            return TriangleNumberHelper.GetFirstTriangleNumberWithAtLeastNDivisor(numberOfDivisors);
        }

        public static long GetSolutionOfProblem13()
        {
            var sum = TestData.TestData.Get100NumbersWith50DigitsProblem13().Aggregate(BigInteger.Add);
            var first10DigitsAsString = sum.ToString().Substring(0, 10);
            return long.Parse(first10DigitsAsString);
        }

        public static long GetSolutionOfProblem14()
        {
            var max = 1000000;
            return CollatzSequenceHelper.GetStartingNumberBelowMaxWithLongestSequence(max);
        }

        public static long GetSolutionOfProblem15()
        {
            var n = 40;
            var k = 20;
            return NumberHelper.BinominalCoefficient(n, k);
        }

        public static long GetSolutionOfProblem16()
        {
            BigInteger n = BigInteger.Pow(2, 1000);
            return NumberHelper.SumOfDigits(n);
        }

        public static long GetSolutionOfProblem17()
        {
            var numberFrom1To1000 = Enumerable.Range(1, 1000).ToList();
            return NumberToWordHelper.SumOfLengthOfNumbersAsWordsWrittenOut(numberFrom1To1000);
        }

        public static long GetSolutionOfProblem18()
        {
            var numberTriangle = TestData.TestData.TriangleProblem18();
            return NumberHelper.MaximalPathOfNumberTriangle(numberTriangle);
        }

        public static long GetSolutionOfProblem19()
        {
            var startDate = new DateTime(1901, 1, 1);
            var endDate = new DateTime(2000, 12, 31);
            return DateHelper.NumberOfSundaysOnTheFirstOfTheMonth(startDate, endDate);
        }

        public static long GetSolutionOfProblem20()
        {
            var factorial = NumberHelper.Factorial(100);
            return NumberHelper.SumOfDigits(factorial);
        }

        public static long GetSolutionOfProblem21()
        {
            var max = 10000;
            return DivisorHelper.GetListOfAmicablePairsBelowMax(max).Sum();
        }

        public static long GetSolutionOfProblem22()
        {
            return TestDataHelper.GetNameScoresForProblem22();
        }

        public static long GetSolutionOfProblem67()
        {
            var numberTriangle = TestData.TestData.TriangleProblem67();
            return NumberHelper.MaximalPathOfNumberTriangle(numberTriangle);
        }
    }
}
