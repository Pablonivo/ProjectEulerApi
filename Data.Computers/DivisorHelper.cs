using System.Collections.Generic;
using System.Linq;

namespace Data.Computers
{
    public static class DivisorHelper
    {
        public static int GetNumberOfDivisors(long n)
        {
            var numberOfDivisors = 1;
            var primeFactorization = PrimeHelper.GetPrimeFactorization(n);
            
            foreach(int key in primeFactorization.Keys)
            {
                numberOfDivisors *= primeFactorization[key] + 1;
            }

            return numberOfDivisors;
        }

        public static List<int> GetListOfProperDivisors(int n)
        {
            var listOfProperDivisors = new List<int>();

            if (n <= 1)
            {
                return listOfProperDivisors;
            }

            foreach(int potentialDivisor in Enumerable.Range(1, n / 2))
            {
                if (n % potentialDivisor == 0)
                {
                    listOfProperDivisors.Add(potentialDivisor);
                }
            }

            return listOfProperDivisors;
        }

        private static int GetSumOfProperDivisors(int n)
        {
            return GetListOfProperDivisors(n).Sum();
        }

        public static bool IsAmicablePair(int a, int b)
        {
            return a != b && GetSumOfProperDivisors(a) == b && GetSumOfProperDivisors(b) == a;
        }

        public static List<int> GetListOfAmicablePairsBelowMax(int max)
        {
            var listOfAmicablePairs = new List<int>();

            foreach (int potentialAmicableNumber in Enumerable.Range(1, max - 1))
            {
                var sumOfProperDivisors = GetSumOfProperDivisors(potentialAmicableNumber);
                if (IsAmicablePair(potentialAmicableNumber, sumOfProperDivisors))
                {
                    listOfAmicablePairs.Add(sumOfProperDivisors);
                }
            }

            return listOfAmicablePairs;
        }
    }
}
