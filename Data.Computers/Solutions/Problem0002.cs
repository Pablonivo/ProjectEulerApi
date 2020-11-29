using System.Collections.Generic;
using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0002 : IProblem
    {
        private readonly int UPPER_BOUND = 4000000;

        public long ComputeSolution()
        {
            var fibonacciNumbersBelowUpperBound = GetFibonacciNumbersBelowUpperBound(UPPER_BOUND);
            var evenFibonacciNumbersBelowUpperBound = GetAllEvenNumbersInList(fibonacciNumbersBelowUpperBound);
            return evenFibonacciNumbersBelowUpperBound.Sum();
        }

        private static List<int> GetFibonacciNumbersBelowUpperBound(int upperBound)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };
            var nextFibonacciNumber = NextFibonacciNumber(fibonacciNumbers);
            while (nextFibonacciNumber < upperBound)
            {
                fibonacciNumbers.Add(nextFibonacciNumber);
                nextFibonacciNumber = NextFibonacciNumber(fibonacciNumbers);
            }
            return fibonacciNumbers;
        }

        private static int NextFibonacciNumber(List<int> fibonacciNumbers)
        {
            return fibonacciNumbers[^1] + fibonacciNumbers[^2];
        }

        private static IEnumerable<int> GetAllEvenNumbersInList(List<int> listOfNumbers)
        {
            return listOfNumbers.Where(x => x % 2 == 0);
        }
    }
}