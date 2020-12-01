using System.Collections.Generic;
using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0023 : IProblem
    {
        // By mathematical analysis it can be proven that numbers greater than 28123 can be written as a sum of abundant numbers.
        // The actual highest number which cannot be written as such a sum is 20161.
        // Hence is order to lower the computation time we use this as upper bound instead.
        private readonly int UPPER_BOUND = 20161;
        private readonly List<int> LIST_OF_ABUNDANT_NUMBERS_BELOW_UPPPER_BOUND = new List<int>();

        public long ComputeSolution()
        {
            LIST_OF_ABUNDANT_NUMBERS_BELOW_UPPPER_BOUND.AddRange(GetListOfAbundantNumberBelowUpperBound(UPPER_BOUND));
            var listOfSumsOfTwoAbundantNumbers = GetListOfSumsOfTwoAbundantNumberBelowUpperBound();
            var listOfNumbersWhichCannotBeWrittenAsSumOfTwoAbundantNumbers = GetNumbersWhichCannotBeWrittenAsSumOfTwoAbundantNumbers(listOfSumsOfTwoAbundantNumbers);
            return listOfNumbersWhichCannotBeWrittenAsSumOfTwoAbundantNumbers.Sum();
        }

        private List<int> GetNumbersWhichCannotBeWrittenAsSumOfTwoAbundantNumbers(List<int> listOfSumsOfTwoAbundantNumbers)
        {
            return Enumerable.Range(1, UPPER_BOUND)
                            .Where(number => !listOfSumsOfTwoAbundantNumbers.Contains(number))
                            .ToList();
        }

        private List<int> GetListOfSumsOfTwoAbundantNumberBelowUpperBound()
        {
            var numberOfAbundantNumbers = LIST_OF_ABUNDANT_NUMBERS_BELOW_UPPPER_BOUND.Count;
            var listOfSumsOfTwoAbundantNumbers = new List<int>();
            foreach (int i in Enumerable.Range(0, numberOfAbundantNumbers - 1))
            {
                foreach (int j in Enumerable.Range(i, numberOfAbundantNumbers - 1 - i))
                {
                    listOfSumsOfTwoAbundantNumbers.Add(LIST_OF_ABUNDANT_NUMBERS_BELOW_UPPPER_BOUND[i] + LIST_OF_ABUNDANT_NUMBERS_BELOW_UPPPER_BOUND[j]);
                }
            }
            listOfSumsOfTwoAbundantNumbers = RemoveDuplicatesAndNumbersHigherThanUpperBound(listOfSumsOfTwoAbundantNumbers);
            return listOfSumsOfTwoAbundantNumbers;
        }

        private List<int> RemoveDuplicatesAndNumbersHigherThanUpperBound(List<int> listOfSumsOfTwoAbundantNumbers)
        {
            listOfSumsOfTwoAbundantNumbers.RemoveAll(number => number > UPPER_BOUND);
            listOfSumsOfTwoAbundantNumbers = listOfSumsOfTwoAbundantNumbers.Distinct().ToList();
            return listOfSumsOfTwoAbundantNumbers;
        }

        private List<int> GetListOfAbundantNumberBelowUpperBound(int max)
        {
            var listOfAbundantNumberBelowMax = new List<int>();
            foreach (int potentialAbundantNumber in Enumerable.Range(1, max - 1))
            {
                if (IsAbundantNumber(potentialAbundantNumber))
                {
                    listOfAbundantNumberBelowMax.Add(potentialAbundantNumber);
                }
            }
            return listOfAbundantNumberBelowMax;
        }

        private bool IsAbundantNumber(int n)
        {
            return DivisorHelper.GetListOfProperDivisors(n).Sum() > n;
        }
    }
}