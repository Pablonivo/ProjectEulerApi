using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}
