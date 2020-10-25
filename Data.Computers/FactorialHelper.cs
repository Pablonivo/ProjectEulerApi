using System;
using System.Linq;
using System.Numerics;

namespace Data.Computers
{
    public static class FactorialHelper
    {
        public static BigInteger Factorial(int n)
        {
            if (n != 1 && n != 0)
            {
                return n * Factorial(n - 1);
            }
            else
            {
                return 1;
            }
        }

        public static BigInteger BinominalCoefficient(int n, int k)
        {
            if (n < k)
            {
                throw new ArgumentException("n should be greater or equal than k");
            }
            return (Factorial(n) / (Factorial(k) * Factorial(n - k)));
        }

        public static bool IsSumOfFactorialOfDigits(long number)
        {
            BigInteger sum = 0;
            var numberAsString = number.ToString();

            foreach(char character in numberAsString)
            {
                var digit = (int)char.GetNumericValue(character);
                sum += Factorial(digit);
            }

            return sum == number;
        }

        public static int NumberOfCombinatoricSelectionsExceedingOneMillion(int max)
        {
            var numberOfCombinatoricSelectionsExceedingOneMillion = 0;

            foreach (int n in Enumerable.Range(1, max))
            {
                foreach (int r in Enumerable.Range(1, n))
                {
                    if (BinominalCoefficient(n, r) >= 1000000)
                    {
                        numberOfCombinatoricSelectionsExceedingOneMillion++;
                    }
                }
            }

            return numberOfCombinatoricSelectionsExceedingOneMillion;
        }
    }
}
