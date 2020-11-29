using System.Collections.Generic;
using System.Numerics;

namespace Data.Computers
{
    public static class FibonacciHelper
    {
        public static int GetIndexOfFirstFibonacciNumberWithAtLeastNDigits(int requiredNumberOfDigits)
        {
            var fibonacciList = new List<BigInteger> { 1, 1 };
            BigInteger nextFibonacciNumber = fibonacciList[^1] + fibonacciList[^2];

            while (nextFibonacciNumber.ToString().Length < requiredNumberOfDigits)
            {
                fibonacciList.Add(nextFibonacciNumber);
                nextFibonacciNumber = fibonacciList[^1] + fibonacciList[^2];
            }

            return fibonacciList.Count + 1;
        }
    }
}
