using System.Collections.Generic;
using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0021 : IProblem
    {
        private readonly int UPPER_BOUND = 10000;

        public long ComputeSolution()
        {
            return GetListOfAmicablePairsBelowMax(UPPER_BOUND).Sum();
        }

        private List<int> GetListOfAmicablePairsBelowMax(int upperBound)
        {
            var listOfAmicablePairs = new List<int>();
            foreach (int potentialAmicableNumber in Enumerable.Range(1, upperBound - 1))
            {
                var sumOfProperDivisors = GetSumOfProperDivisors(potentialAmicableNumber);
                if (IsAmicablePair(potentialAmicableNumber, sumOfProperDivisors))
                {
                    listOfAmicablePairs.Add(sumOfProperDivisors);
                }
            }
            return listOfAmicablePairs;
        }

        private bool IsAmicablePair(int a, int b)
        {
            return a != b && GetSumOfProperDivisors(a) == b && a == GetSumOfProperDivisors(b);
        }

        private int GetSumOfProperDivisors(int n)
        {
            return DivisorHelper.GetListOfProperDivisors(n).Sum();
        }
    }
}