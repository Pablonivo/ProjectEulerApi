using System.Collections.Generic;
using System.Numerics;

namespace Data.Computers.Solutions
{
    public class Problem0025 : IProblem
    {
        private readonly int REQUIRED_NUMBER_OF_DIGITS = 1000;
        private readonly List<BigInteger> FIBONACCI_LIST = new List<BigInteger> { 1, 1 };

        public Problem0025(int requiredNumberOfDigits)
        {
            REQUIRED_NUMBER_OF_DIGITS = requiredNumberOfDigits;
        }

        public Problem0025()
        {

        }

        public long ComputeSolution()
        {
            BigInteger nextFibonacciNumber = GetNextFibonacciNumber();
            while (nextFibonacciNumber.ToString().Length < REQUIRED_NUMBER_OF_DIGITS)
            {
                FIBONACCI_LIST.Add(nextFibonacciNumber);
                nextFibonacciNumber = GetNextFibonacciNumber();
            }
            return FIBONACCI_LIST.Count + 1;
        }

        private BigInteger GetNextFibonacciNumber()
        {
            return FIBONACCI_LIST[^1] + FIBONACCI_LIST[^2];
        }
    }
}