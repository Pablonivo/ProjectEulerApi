using System.Collections.Generic;
using System.Linq;
using Data.Computers.DataFiles;

namespace Data.Computers.Solutions
{
    public class Problem0022 : IProblem
    {
        private readonly List<string> LIST_OF_NAMES = TestData.TestData.FirstNamesProblem22();

        public long ComputeSolution()
        {
            long totalScore = 0;
            foreach (int i in Enumerable.Range(0, LIST_OF_NAMES.Count))
            {
                totalScore += (i + 1) * TestDataHelper.GetWordScore(LIST_OF_NAMES[i]);
            }
            return totalScore;
        }
    }
}