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

        public static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }

        public static (int, int, int) GetPythagoreanTripletForWhichSumEquals(int sum)
        {
            for (int a = 1; a < sum / 3; a++)
            {
                for (int b = a + 1; b < 2 * sum / 3; b++)
                {
                    int c = sum - a - b;

                    if (c > b && IsPythagoreanTriplet(a, b, c))
                    {
                        return (a, b, c);
                    }
                }
            }

            return (0, 0, 0);
        }

        public static long BinominalCoefficient(int n, int k)
        {
            if (n < k)
            {
                throw new ArgumentException("n should be greater or equal than k");
            }
            return (long)(Factorial(n) / (Factorial(k) * Factorial(n -k)));
        }

        public static BigInteger Factorial(int n)
        {
            if (n != 1 && n != 0)
            {
                return n * Factorial(n-1);
            }
            else
            {
                return 1;
            }
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

        public static long MaximalPathOfNumberTriangle(int [ , ] triangleGrid)
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
                foreach(int i in Enumerable.Range(1, 4))
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

                    foreach(int i in Enumerable.Range(0, numberOfTimesHighestNumberInListFitsInNumber + 1))
                    {
                        numberOfWaysToWriteNumberAsSum += NumberOfWaysToWriteNumberAsSum(requiredSum - i * highestNumberToUse, numberToUseWithoutHighestNumber);
                    }

                    return numberOfWaysToWriteNumberAsSum;
            }
        }
    }
}
