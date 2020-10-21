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
            var sum = 0;
            var bigIntAsString = n.ToString();

            for (int i = 0; i < bigIntAsString.Length; i++)
            {
                sum += (int)char.GetNumericValue(bigIntAsString[i]);
            }

            return sum;
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
                foreach (int i in Enumerable.Range(1, 4))
                {
                    currentPosition += increment;
                    sum += currentPosition;
                }

                increment += 2;
            }

            return sum;
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

        public static bool AreNumbersPermutations(long number1, long number2)
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
    }
}
