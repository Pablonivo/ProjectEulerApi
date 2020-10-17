using System;
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

        public static long BinominalCoefficient(int n, int k)
        {
            if (n < k)
            {
                throw new ArgumentException("n should be greater or equal than k");
            }
            return (long)(Factorial(n) / (Factorial(k) * Factorial(n - k)));
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
    }
}
