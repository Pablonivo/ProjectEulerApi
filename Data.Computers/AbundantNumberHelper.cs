using System.Collections.Generic;
using System.Linq;

namespace Data.Computers
{
    public static class AbundantNumberHelper
    {
        public static bool IsAbundantNumber(int n)
        {
            return DivisorHelper.GetListOfProperDivisors(n).Sum() > n;
        }

        public static List<int> GetListOfAbundantNumberBelowMax(int max)
        {
            var listOfAbundantNumberBelowMax = new List<int>();

            foreach(int potentialAbundantNumber in Enumerable.Range(1, max - 1))
            {
                if (IsAbundantNumber(potentialAbundantNumber))
                {
                    listOfAbundantNumberBelowMax.Add(potentialAbundantNumber);
                }
            }

            return listOfAbundantNumberBelowMax;
        }

        public static long GetSumOfIntegersWhichCannotBeWrittenAsSumOfTwoAbundantNumber()
        {
            // By mathematical analysis it can be proven that numbers greater than 28123 can be written as a sum of abundant numbers.
            // The actual highest number which cannot be written as such a sum is 20161.
            // Hence is order to lower the computation time we use this as upper bound instead.
            var UPPER_BOUND = 20161;
            var listOfAbundantNumbersBelowUpperBound = GetListOfAbundantNumberBelowMax(UPPER_BOUND);
            var numberOfAbundantNumbers = listOfAbundantNumbersBelowUpperBound.Count;
            var listOfSumsOfTwoAbundantNumbers = new List<int>();
            var listOfNumbersWhichCannotBeWrittenAsSumOfTwoAbundantNumbers = new List<int>();
            
            foreach(int i in Enumerable.Range(0, numberOfAbundantNumbers - 1))
            {
                foreach (int j in Enumerable.Range(i, numberOfAbundantNumbers - 1 - i))
                {
                    listOfSumsOfTwoAbundantNumbers.Add(listOfAbundantNumbersBelowUpperBound[i] + listOfAbundantNumbersBelowUpperBound[j]);
                }
            }

            listOfSumsOfTwoAbundantNumbers.RemoveAll(number => number > UPPER_BOUND);
            listOfSumsOfTwoAbundantNumbers = listOfSumsOfTwoAbundantNumbers.Distinct().ToList();

            listOfNumbersWhichCannotBeWrittenAsSumOfTwoAbundantNumbers = Enumerable.Range(1, UPPER_BOUND)
                .Where(number => !listOfSumsOfTwoAbundantNumbers.Contains(number))
                .ToList();

            return listOfNumbersWhichCannotBeWrittenAsSumOfTwoAbundantNumbers.Sum();
        }
    }
}
