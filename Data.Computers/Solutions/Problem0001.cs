using System.Collections.Generic;
using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0001 : IProblem
    {
        private readonly int UPPER_BOUND = 1000;

        public long ComputeSolution()
        {
            var multiplesOfThree = GetMultiplesOfNumberBelowUpperBound(3, UPPER_BOUND);
            var multiplesOfFive = GetMultiplesOfNumberBelowUpperBound(5, UPPER_BOUND);
            var multiplesOfThreeAndFiveBelowUpperBound = multiplesOfThree.Union(multiplesOfFive);
            return multiplesOfThreeAndFiveBelowUpperBound.Sum();
        }

        private static List<int> GetMultiplesOfNumberBelowUpperBound(int number, int upperBound)
        {
            var multiplesList = new List<int>();
            for (int i = 1; number * i < upperBound; i++)
            {
                multiplesList.Add(number * i);
            }
            return multiplesList;
        }
    }
}
