using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0005 : IProblem
    {
        private readonly int UPPER_BOUND = 20;

        public Problem0005(int number)
        {
            UPPER_BOUND = number;
        }

        public Problem0005()
        {

        }

        public long ComputeSolution()
        {
            var numbersFrom1ToUpperBound = Enumerable.Range(1, UPPER_BOUND);
            return GetSmallestMultiple(numbersFrom1ToUpperBound);
        }

        private static long GetSmallestMultiple(IEnumerable<int> numbers)
        {
            long smallestMultiple = 1;
            var listOfFactorizations = numbers.Select(number => PrimeHelper.GetPrimeFactorization(number));
            Dictionary<int, int> factorizationOfAnswer = GetPrimeFactorizationOfSmallestMultiple(listOfFactorizations);
            foreach (var key in factorizationOfAnswer.Keys)
            {
                smallestMultiple *= (long)Math.Pow(key, factorizationOfAnswer[key]);
            }
            return smallestMultiple;
        }

        private static Dictionary<int, int> GetPrimeFactorizationOfSmallestMultiple(IEnumerable<Dictionary<int, int>> listOfFactorizations)
        {
            var primeFactorizationOfSmallestMultiple = new Dictionary<int, int>();
            foreach (var factorization in listOfFactorizations)
            {
                foreach (var key in factorization.Keys)
                {
                    if (!primeFactorizationOfSmallestMultiple.ContainsKey(key) || primeFactorizationOfSmallestMultiple[key] < factorization[key])
                    {
                        primeFactorizationOfSmallestMultiple[key] = factorization[key];
                    }
                }
            }
            return primeFactorizationOfSmallestMultiple;
        }
    }
}