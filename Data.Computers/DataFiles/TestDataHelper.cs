using System.Linq;

namespace Data.Computers.DataFiles
{
    public static class TestDataHelper
    {
        public static long GetNameScoresForProblem22()
        {
            long totalScore = 0;
            var listOfNames = TestData.TestData.FirstNamesProblem22();
            listOfNames.Sort();

            foreach(int i in Enumerable.Range(0, listOfNames.Count))
            {
                totalScore += (i + 1) * GetNameScore(listOfNames[i]);
            }

            return totalScore;
        }

        public static int GetNameScore(string name)
        {
            var nameScore = 0;

            foreach (char letter in name)
            {
                nameScore += MapLetterToAlphabeticalValue(letter);
            }

            return nameScore;
        }

        private static int MapLetterToAlphabeticalValue(char letter)
        {
            return letter % 32;
        }
    }
}
