using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0006 : IProblem
    {
        private readonly int UPPER_BOUND = 100;

        public Problem0006(int number)
        {
            UPPER_BOUND = number;
        }

        public Problem0006()
        {

        }

        public long ComputeSolution()
        {
            var numbersFrom1ToUpperBound = Enumerable.Range(1, UPPER_BOUND);
            long sumOfSquares = GetSumOfSquares(numbersFrom1ToUpperBound);
            long squareOfSum = GetSquareOfSum(numbersFrom1ToUpperBound);
            return squareOfSum - sumOfSquares;
        }

        private static long GetSumOfSquares(IEnumerable<int> numbers)
        {
            return numbers.Select(x => x * x).Sum();
        }

        private static long GetSquareOfSum(IEnumerable<int> numbers)
        {
            return (long)Math.Pow(numbers.Sum(), 2);
        }
    }
}