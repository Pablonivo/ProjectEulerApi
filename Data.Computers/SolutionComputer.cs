﻿using System;
using System.Collections.Generic;
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
            var (a, b, c) = PythagoreanTripletHelper.GetPythagoreanTripletForWhichSumEquals(sum).Single();
            return a * b * c;
        }

        public static long GetSolutionOfProblem10()
        {
            var max = 2000000;
            return PrimeHelper.SieveOfEratosthenes(max).Sum();
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
            return (long)FactorialHelper.BinominalCoefficient(n, k);
        }

        public static long GetSolutionOfProblem16()
        {
            BigInteger n = BigInteger.Pow(2, 1000);
            return NumberHelper.SumOfDigits(n);
        }

        public static long GetSolutionOfProblem17()
        {
            var numbersFrom1To1000 = Enumerable.Range(1, 1000).ToList();
            return NumberToWordHelper.SumOfLengthOfNumbersAsWordsWrittenOut(numbersFrom1To1000);
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
            var factorial = FactorialHelper.Factorial(100);
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

        public static long GetSolutionOfProblem23()
        {
            return AbundantNumberHelper.GetSumOfIntegersWhichCannotBeWrittenAsSumOfTwoAbundantNumber();
        }

        public static long GetSolutionOfProblem24()
        {
            var desiredIndex = 1000000;
            var listOfCharacters = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return long.Parse(PermutationHelper.GetNthLexiographicPermutation(desiredIndex, listOfCharacters));
        }

        public static long GetSolutionOfProblem25()
        {
            var requiredNumberOfDigits = 1000;
            return FibonacciHelper.GetIndexOfFirstFibonacciNumberWithAtLeastNDigits(requiredNumberOfDigits);
        }

        public static long GetSolutionOfProblem26()
        {
            var max = 1000;
            return FractionHelper.GetLongestRecurringCycleFor1OverDBelowMax(max);
        }

        public static long GetSolutionOfProblem27()
        {
            var maxModulus = 1000;
            var (a, b) = QuadraticFormulaHelper.GetCoefficientsForQuadraticExpressionWhichProducesMaximumNumberOfPrimes(maxModulus);
            return a * b;
        }

        public static long GetSolutionOfProblem28()
        {
            var sizeOfSpiralSides = 1001;
            return NumberHelper.GetSumOfDiagonalsNumberSpiral(sizeOfSpiralSides);
        }

        public static long GetSolutionOfProblem29()
        {
            var maxOfIntegersUsed = 100;
            return NumberHelper.GetListOfDistinctPowers(maxOfIntegersUsed).Count();
        }

        public static long GetSolutionOfProblem30()
        {
            var power = 5;
            return NumberHelper.GetIntegersWhichCanBeWrittenAsNthPowersOfTheirDigits(power).Sum();
        }

        public static long GetSolutionOfProblem31()
        {
            var allowedNumbersInSum = new List<int> { 1, 2, 5, 10, 20, 50, 100, 200 };
            var requiredSum = 200;
            return NumberHelper.NumberOfWaysToWriteNumberAsSum(requiredSum, allowedNumbersInSum);
        }

        public static long GetSolutionOfProblem32()
        {
            var listOfCharacters = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return PandigitalHelper.GetListOfPandigitalProducts(listOfCharacters).Sum();
        }

        public static long GetSolutionOfProblem33()
        {
            var maxOfFractionParts = 99;
            var listOfFractions = FractionHelper.GetListOfFractionsThatCanBeSimplifiedIncorrectly(maxOfFractionParts);
            var productOfNumerators = listOfFractions.Select(fraction => fraction.Item1).Aggregate(1, (a, b) => a * b);
            var productOfDenominators = listOfFractions.Select(fraction => fraction.Item2).Aggregate(1, (a, b) => a * b);
            return FractionHelper.ToLowestTerms(productOfNumerators, productOfDenominators).Item2;
        }

        public static long GetSolutionOfProblem34()
        {
            // An easy upper bound is 10 000 000, but the computation shows they are all below 50 000. 
            var upperBound = 50000;
            var listOfNumbersThatCanBeWrittenAsSumOfFactorialsOfDigits =
                Enumerable.Range(3, upperBound)
                .Where(number => FactorialHelper.IsSumOfFactorialOfDigits(number));
            return listOfNumbersThatCanBeWrittenAsSumOfFactorialsOfDigits.Sum();
        }

        public static long GetSolutionOfProblem35()
        {
            var max = 1000000;
            return PrimeHelper.GetListOfCircularPrimesBelowMax(max).Count();
        }

        public static long GetSolutionOfProblem36()
        {
            var max = 1000000;
            return Enumerable.Range(0, max)
                .Where(number => PalindromeHelper.IsPalindrome(number) && PalindromeHelper.IsPalindromeInBase2(number))
                .ToList().Sum();
        }

        public static long GetSolutionOfProblem37()
        {
            return PrimeHelper.GetAllTruncatablePrimes().Sum();
        }

        public static long GetSolutionOfProblem38()
        {
            return PandigitalHelper.GetLargest1To9PandigitalConcatenatedProduct();
        }

        public static long GetSolutionOfProblem39()
        {
            var maximalPerimeter = 1000;
            return PythagoreanTripletHelper.GetPerimeterBelowMaxWithMostSolutions(maximalPerimeter);
        }

        public static long GetSolutionOfProblem40()
        {
            var desiredDigits = new List<int> { 1, 10, 100, 1000, 10000, 100000, 1000000 };
            var digits = desiredDigits.Select(desiredDigit => ChampernowneHelper.GetNthDigitOfChampernownesConstant(desiredDigit)).ToList();
            return digits.Aggregate(1, (a, b) => a * b);
        }

        public static long GetSolutionOfProblem41()
        {
            return PandigitalHelper.GetLargestNPandigitalPrime();
        }

        public static long GetSolutionOfProblem42()
        {
            // A letter has a value of at most 26.
            // We assume that all words are at most 100 letters long, so max = 26 * 100 = 2600;
            var max = 2600;
            var triangleNumbersBelowMax = TriangleNumberHelper.GetListOfTriangleNumbersBelowMax(max);
            var wordList = TestData.TestData.EnglishWordsProblem42();
            return wordList.Where(word => triangleNumbersBelowMax.Contains(TestDataHelper.GetWordScore(word))).Count();
        }

        public static long GetSolutionOfProblem43()
        {
            return PandigitalHelper.Get0To9PandigitalNumbersWhichSatisfySubstringDivisibility().Sum();
        }

        public static long GetSolutionOfProblem44()
        {
            return PentagonNumberHelper.GetMinimalDistanceOfPentagonalNumbersForWhichSumAndDifferenceArePentagonal();
        }

        public static long GetSolutionOfProblem45()
        {
            // The first number is 1, the second is 40755 (as given), so we are looking for the third.
            var count = 3; 
            return TriangleNumberHelper.GetFirstNTriangleNumbersWhichAreAlsoPentagonalAndHexogonal(count).Last();
        }

        public static long GetSolutionOfProblem46()
        {
            return PrimeHelper.GetFirstCounterExampleGoldbachsOtherConjecture();
        }

        public static long GetSolutionOfProblem47()
        {
            var consecutiveNumbers = 4;
            var numberOfDistinctPrimeFactors = 4;
            return PrimeHelper.GetFirstNumberOfConsecutiveNumbersToHaveMDistinctPrimeFactors(consecutiveNumbers, numberOfDistinctPrimeFactors);
        }

        public static long GetSolutionOfProblem48()
        {
            var n = 1000;
            var desiredNumberOfDigits = 10;
            return (long)NumberHelper.SumOfFirstNSelfPowersModuloM(n, desiredNumberOfDigits);
        }

        public static long GetSolutionOfProblem49()
        {
            var arithmeticSequences = PrimeHelper.ArithmeticPrimePermutationsWith4Digits();
            var sequenceWeAreLookingFor = arithmeticSequences[arithmeticSequences.Keys.ToList().Where(number => number != 1487).Single()];
            return long.Parse(sequenceWeAreLookingFor[0].ToString() + sequenceWeAreLookingFor[1].ToString() + sequenceWeAreLookingFor[2].ToString());
        }

        public static long GetSolutionOfProblem50()
        {
            var max = 1000000;
            return PrimeHelper.PrimeBelowMaxWhichCanBeWrittenAsSumOfMostConsectivePrimes(max);
        }

        public static long GetSolutionOfProblem51()
        {
            var desiredSizeOfFamily = 8;
            return PrimeHelper.FirstPrimeWhichHasDesiredSizeOfFamilyByReplacingSomeDigitsBySameNumber(desiredSizeOfFamily);
        }

        public static long GetSolutionOfProblem52()
        {
            return NumberHelper.SmallestNumberSuchThat2345And6TimesTheNumberArePermutationsOfOriginalNumber();
        }

        public static long GetSolutionOfProblem53()
        {
            var max = 100;
            return FactorialHelper.NumberOfCombinatoricSelectionsExceedingOneMillion(max);
        }

        public static long GetSolutionOfProblem54()
        {
            var pokerHands = TestData.TestData.PokerHandsProblem54();
            var winnerList = new List<int>();

            foreach (int i in Enumerable.Range(0, pokerHands.Item1.Count))
            {
                winnerList.Add(PokerHelper.ComputeWinner(pokerHands.Item1[i], pokerHands.Item2[i]));
            }

            return winnerList.Where(winner => winner == 1).Count();
        }

        public static long GetSolutionOfProblem55()
        {
            var maxNumberOfSteps = 50;
            var max = 10000;
            var numbersToCheck = Enumerable.Range(1, max - 1);

            // Note that we assume that numbers below 10000 which are not Lynchrel can be find in maxNumberOfSteps, but this is not neccearily true.
            var numberOfLynchrelNumbersInRange = numbersToCheck.Where(number => NumberHelper.IsALynchrelNumberInMaxNumberOfSteps(number, maxNumberOfSteps));
            return numberOfLynchrelNumbersInRange.Count();
        }

        public static long GetSolutionOfProblem56()
        {
            var max = 99;
            return NumberHelper.MaximalDigitSum(max);
        }

        public static long GetSolutionOfProblem67()
        {
            var numberTriangle = TestData.TestData.TriangleProblem67();
            return NumberHelper.MaximalPathOfNumberTriangle(numberTriangle);
        }
    }
}
