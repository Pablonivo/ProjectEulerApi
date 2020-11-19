using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Data.Computers
{
    public static class NumberHelper
    {
        public static List<int> GetMultiplesOfNumberBelowMax(int number, int max)
        {
            var multiplesList = new List<int>();

            for (int i = 1; number * i < max; i++)
            {
                multiplesList.Add(number * i);
            }

            return multiplesList;
        }

        public static long GetSmallestMultiple(List<int> numbers)
        {
            var listOfFactorizations = numbers.Select(number => PrimeHelper.GetPrimeFactorization(number));
            var factorizationOfAnswer = new Dictionary<int, int>();

            foreach (var factorization in listOfFactorizations)
            {
                foreach (var key in factorization.Keys)
                {
                    if (!factorizationOfAnswer.ContainsKey(key) || factorizationOfAnswer[key] < factorization[key])
                    {
                        factorizationOfAnswer[key] = factorization[key];
                    }
                }
            }

            long smallestMultiple = 1;
            foreach (var key in factorizationOfAnswer.Keys)
            {
                smallestMultiple *= (long)Math.Pow(key, factorizationOfAnswer[key]);
            }

            return smallestMultiple;
        }

        public static long GetLargestProductOfAdjacentNumbersInString(string series, int numberOfAdjacentDigits)
        {
            long largestProductFound = 0;

            for (int i = 0; i < series.Length - numberOfAdjacentDigits; i++)
            {
                long currentProduct = 1;
                for (int j = i; j < i + numberOfAdjacentDigits; j++)
                {
                    currentProduct *= (long)char.GetNumericValue(series[j]);
                }

                if (currentProduct > largestProductFound)
                {
                    largestProductFound = currentProduct;
                }
            }

            return largestProductFound;
        }

        public static long GetLargestProductOf4AdjacentNumberInGrid(int[,] grid)
        {
            var largestProductFound = 0;
            var numberOfAdjacentDigits = 4;
            var sizeOfGrid = 20;

            for (int i = 0; i < sizeOfGrid; i++)
            {
                for (int j = 0; j < sizeOfGrid - numberOfAdjacentDigits; j++)
                {
                    var currentProduct = grid[i, j] * grid[i, j + 1] * grid[i, j + 2] * grid[i, j + 3];
                    if (currentProduct > largestProductFound)
                    {
                        largestProductFound = currentProduct;
                    }
                }
            }

            for (int i = 0; i < sizeOfGrid - numberOfAdjacentDigits; i++)
            {
                for (int j = 0; j < sizeOfGrid; j++)
                {
                    var currentProduct = grid[i, j] * grid[i + 1, j] * grid[i + 2, j] * grid[i + 3, j];
                    if (currentProduct > largestProductFound)
                    {
                        largestProductFound = currentProduct;
                    }
                }
            }

            for (int i = 0; i < sizeOfGrid - numberOfAdjacentDigits; i++)
            {
                for (int j = 0; j < sizeOfGrid - numberOfAdjacentDigits; j++)
                {
                    var currentProduct = grid[i, j] * grid[i + 1, j + 1] * grid[i + 2, j + 2] * grid[i + 3, j + 3];
                    if (currentProduct > largestProductFound)
                    {
                        largestProductFound = currentProduct;
                    }
                }
            }

            for (int i = 0; i < sizeOfGrid - numberOfAdjacentDigits; i++)
            {
                for (int j = numberOfAdjacentDigits - 1; j < sizeOfGrid; j++)
                {
                    var currentProduct = grid[i, j] * grid[i + 1, j - 1] * grid[i + 2, j - 2] * grid[i + 3, j - 3];
                    if (currentProduct > largestProductFound)
                    {
                        largestProductFound = currentProduct;
                    }
                }
            }

            return largestProductFound;
        }

        public static long SumOfDigits(BigInteger n)
        {
            return ListOfDigits(n).Sum();
        }

        public static long SumOfSquaresOfDigits(BigInteger n)
        {
            return ListOfDigits(n).Select(digit => digit * digit).Sum();
        }

        public static int NumberOfDigits(BigInteger n)
        {
            return ListOfDigits(n).Count;
        }

        private static List<int> ListOfDigits(BigInteger n)
        {
            // This is added just for the case n = 0.
            var listOfDigits = new List<int> { (int)(n % 10) };
            n /= 10;

            while (n != 0)
            {
                listOfDigits.Add((int)(n % 10));
                n /= 10;
            }

            return listOfDigits;
        }

        public static long MaximalPathOfNumberTriangle(int[,] triangleGrid)
        {
            var numberOfRows = (int)Math.Sqrt(triangleGrid.Length);

            for (int i = numberOfRows - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    triangleGrid[i, j] += Math.Max(triangleGrid[i + 1, j], triangleGrid[i + 1, j + 1]);
                }
            }

            return triangleGrid[0, 0];
        }

        public static long GetSumOfDiagonalsNumberSpiral(int spiralSizeOfSides)
        {
            long sum = 1;
            int increment = 2;
            int currentPosition = 1;

            while (currentPosition < spiralSizeOfSides * spiralSizeOfSides)
            {
                for (int i = 0; i <= 3; i++)
                {
                    currentPosition += increment;
                    sum += currentPosition;
                }

                increment += 2;
            }

            return sum;
        }

        public static long GetLengthOfNumberSpiralForWhichPercentageOfPrimesOnDiagonalsIsLowerThanLimit(int desiredUpperBoundPercentagePrimes)
        {
            var numberOfDiagonalNumbers = 5;
            var numberOfPrimesOnDiagonals = 3;

            int increment = 2;
            int currentPosition = 9;

            while (!(numberOfPrimesOnDiagonals * 100 <= numberOfDiagonalNumbers * desiredUpperBoundPercentagePrimes))
            {
                increment += 2;

                // The odd squares lie on the bottom right diagonal, so these cannot be prime.
                for (int i = 0; i < 3; i++)
                {
                    currentPosition += increment;

                    if (PrimeHelper.IsPrime(currentPosition))
                    {
                        numberOfPrimesOnDiagonals++;
                    }
                }

                currentPosition += increment;
                numberOfDiagonalNumbers += 4;
            }

            return increment + 1;
        }

        public static List<BigInteger> GetListOfDistinctPowers(int max)
        {
            var listOfPowers = new List<BigInteger>();
            var allowedIntegers = Enumerable.Range(2, max - 1);

            foreach (int a in allowedIntegers)
            {
                foreach (int b in allowedIntegers)
                {
                    listOfPowers.Add(BigInteger.Pow(a, b));
                }
            }

            return listOfPowers.Distinct().ToList();
        }

        public static List<long> GetIntegersWhichCanBeWrittenAsNthPowersOfTheirDigits(int nthPower)
        {
            var listOfDesiredIntegers = new List<long>();
            var numbersToCheck = Enumerable.Range(2, (int)Math.Pow(10, nthPower + 1));

            foreach (int number in numbersToCheck)
            {
                if (IsIntegerSumOfNthPowerOfDigits(number, nthPower))
                {
                    listOfDesiredIntegers.Add(number);
                }
            }

            return listOfDesiredIntegers;
        }

        public static bool IsIntegerSumOfNthPowerOfDigits(int number, int power)
        {
            var sum = 0;

            foreach (char digit in number.ToString())
            {
                sum += (int)Math.Pow(char.GetNumericValue(digit), power);
            }

            return sum == number;
        }

        public static int NumberOfWaysToWriteNumberAsSum(int requiredSum, List<int> numbersAllowedInSum)
        {
            var numberOfWaysToWriteNumberAsSum = 0;
            var orderedListOfNumbersToUseFromHighToLow = numbersAllowedInSum.OrderByDescending(number => number);

            switch (numbersAllowedInSum.Count)
            {
                case 0:
                    return 0;
                case 1:
                    if (requiredSum % orderedListOfNumbersToUseFromHighToLow.Single() == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                default:
                    var highestNumberToUse = orderedListOfNumbersToUseFromHighToLow.First();
                    var numberOfTimesHighestNumberInListFitsInNumber = requiredSum / highestNumberToUse;
                    var numberToUseWithoutHighestNumber = orderedListOfNumbersToUseFromHighToLow.Where(number => number != highestNumberToUse).ToList();

                    foreach (int i in Enumerable.Range(0, numberOfTimesHighestNumberInListFitsInNumber + 1))
                    {
                        numberOfWaysToWriteNumberAsSum += NumberOfWaysToWriteNumberAsSum(requiredSum - i * highestNumberToUse, numberToUseWithoutHighestNumber);
                    }

                    return numberOfWaysToWriteNumberAsSum;
            }
        }

        public static bool IsSquare(long integer)
        {
            return Math.Sqrt(integer) % 1 == 0;
        }

        public static BigInteger SumOfFirstNSelfPowersModuloM(int max, int desiredNumberOfDigits)
        {
            BigInteger sum = 0;
            var modulus = (long)Math.Pow(10, desiredNumberOfDigits);

            foreach (int i in Enumerable.Range(1, max))
            {
                sum += BigInteger.Pow(i, i) % modulus;
            }

            return sum % modulus;
        }

        public static bool AreNumbersPermutations(BigInteger number1, BigInteger number2)
        {
            var number1AsString = number1.ToString();
            var number2AsString = number2.ToString();
            var lengthNumber1 = number1AsString.Length;

            if (lengthNumber1 != number2AsString.Length)
            {
                return false;
            }

            foreach (int i in Enumerable.Range(1, lengthNumber1))
            {
                if (number2AsString.Contains(number1AsString[0]))
                {
                    number2AsString = number2AsString.Remove(number2AsString.IndexOf(number1AsString[0]), 1);
                    number1AsString = number1AsString.Remove(0, 1);
                }

                else
                {
                    return false;
                }
            }

            return true;
        }

        public static List<long> GetArithmeticSequenceFromList(List<long> numberList)
        {
            var arithmeticSequence = new List<long>();

            foreach (long firstNumber in numberList)
            {
                var numbersWithoutFirst = numberList.Where(number => number != firstNumber);

                foreach (long secondNumber in numbersWithoutFirst)
                {
                    var difference = secondNumber - firstNumber;
                    var thirdNumber = secondNumber + difference;
                    
                    if (numberList.Contains(thirdNumber))
                    {
                        return new List<long>{ firstNumber, secondNumber, thirdNumber};
                    }
                }
            }

            return arithmeticSequence;
        }

        public static int SmallestNumberSuchThat2345And6TimesTheNumberArePermutationsOfOriginalNumber()
        {
            foreach (int i in Enumerable.Range(2, int.MaxValue - 2))
            {
                if (AreNumbersPermutations(i, 2 * i) &&
                    AreNumbersPermutations(i, 3 * i) &&
                    AreNumbersPermutations(i, 4 * i) &&
                    AreNumbersPermutations(i, 5 * i) &&
                    AreNumbersPermutations(i, 6 * i))
                {
                    return i;
                }
            }

            return 0;
        }

        public static long MaximalDigitSum(int max)
        {
            long maximalDigitalSum = 0;

            foreach (int a in Enumerable.Range(1, max))
            {
                foreach (int b in Enumerable.Range(1, max))
                {
                    var digitalSum = SumOfDigits(BigInteger.Pow(a, b));
                    
                    if (digitalSum > maximalDigitalSum)
                    {
                        maximalDigitalSum = digitalSum;
                    }
                }
            }

            return maximalDigitalSum;
        }

        public static BigInteger Reverse(BigInteger number)
        {
            BigInteger reversedNumber = 0;

            while (number != 0)
            {
                var lastDigitOfNumber = number % 10;
                reversedNumber = 10 * reversedNumber + lastDigitOfNumber;
                number /= 10;
            }

            return reversedNumber;
        }

        public static bool IsALynchrelNumberInMaxNumberOfSteps(BigInteger number, int maximumNumberOfSteps)
        {
            foreach (int _ in Enumerable.Range(1, maximumNumberOfSteps))
            {
                number += Reverse(number);
                if (PalindromeHelper.IsPalindrome(number))
                {
                    return false;
                }
            }

            return true;
        }

        public static List<BigInteger> AllNDigitPositiveIntegersWhichAreNthPowers()
        {
            var listOfIntegersWhichAreNthPowers = new List<BigInteger>();
            int exponential = 1;

            while (true)
            {
                for (int i = 1; i <= 9; i++)
                {
                    var nthPower = BigInteger.Pow(i, exponential);
                    var numberOfDigitsOfNthPower = nthPower.ToString().Length;
                    
                    if (numberOfDigitsOfNthPower == exponential)
                    {
                        listOfIntegersWhichAreNthPowers.Add(nthPower);
                    }

                    if (i == 9 && numberOfDigitsOfNthPower < exponential)
                    {
                        return listOfIntegersWhichAreNthPowers.Distinct().ToList();
                    }
                }

                exponential++;
            }
        }

        public static BigInteger NumberOfStartingNumbersForWhichSquareDigitChainEndsAt89(int limit)
        {
            var numberOfDigits = NumberOfDigits(limit);
            var maxNumberToCheck = 9 * 9 * numberOfDigits;
            var startingNumberList = new int[maxNumberToCheck + 1];

            startingNumberList[1] = 1;
            startingNumberList[89] = 89;

            foreach (int i in Enumerable.Range(1, maxNumberToCheck))
            {
                if (startingNumberList[i] != 1 && startingNumberList[i] != 89)
                {
                    var listOfNumbersInCurrentSequence = new List<int> { i };
                    var nextNumber = i;

                    while (true)
                    {
                        nextNumber = (int)SumOfSquaresOfDigits(nextNumber);
                        listOfNumbersInCurrentSequence.Add(nextNumber);

                        if (startingNumberList[nextNumber] == 1 || startingNumberList[nextNumber] == 89)
                        {
                            foreach(int j in listOfNumbersInCurrentSequence)
                            {
                                startingNumberList[j] = startingNumberList[nextNumber];
                            }
                            break;
                        }
                    }
                }
            }

            BigInteger numberOfTimesSequenceEndsAt89 = 0;
            var listOfCharacters = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var listOfPermutations = PermutationHelper.ListOfNumbersWithIncreasingDigits(numberOfDigits, listOfCharacters);

            foreach (string permutation in listOfPermutations)
            {
                if (startingNumberList[SumOfSquaresOfDigits(long.Parse(permutation))] == 89)
                {
                    numberOfTimesSequenceEndsAt89 += PermutationHelper.NumberOfPermutations(permutation);
                }
            }

            return numberOfTimesSequenceEndsAt89;
        }

        public static long SmallestCubeWhichHasNCubicPermutations(int desiredNumberOfCubicPermutations)
        {
            var numberOfDigitsOfCurrentCubes = 1;
            BigInteger index = 1;

            while (true)
            {
                var listOfCubesWithSameDigits = new List<BigInteger>();
                BigInteger currentCube = index * index * index;

                while (currentCube.ToString().Length == numberOfDigitsOfCurrentCubes)
                {
                    listOfCubesWithSameDigits.Add(currentCube);
                    index++;
                    currentCube = index * index * index;
                }

                foreach (BigInteger cube in listOfCubesWithSameDigits)
                {
                    var permutationsOfCube = listOfCubesWithSameDigits.Where(otherCube => AreNumbersPermutations(cube, otherCube));
                    
                    if (permutationsOfCube.Count() == desiredNumberOfCubicPermutations)
                    {
                        return (long)cube;
                    }
                }

                index++;
                numberOfDigitsOfCurrentCubes++;
            }
        }
    }
}
