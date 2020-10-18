using System.Collections.Generic;
using System.Linq;

namespace Data.Computers
{
    public static class PythagoreanTripletHelper
    {
        public static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }

        public static List<(int, int, int)> GetPythagoreanTripletForWhichSumEquals(int sum)
        {
            var listOfSolutions = new List<(int, int, int)>();

            for (int a = 1; a < sum / 3; a++)
            {
                for (int b = a + 1; b < 2 * sum / 3; b++)
                {
                    int c = sum - a - b;

                    if (c > b && IsPythagoreanTriplet(a, b, c))
                    {
                        listOfSolutions.Add((a, b, c));
                    }
                }
            }

            return listOfSolutions;
        }

        public static int GetPerimeterBelowMaxWithMostSolutions(int max)
        {
            var perimeterWithMostSolutions = 0;
            var maximalNumberOfSolutionsFound = 0;

            foreach (int perimeter in Enumerable.Range(1, max))
            {
                var numberOfSolutions = GetPythagoreanTripletForWhichSumEquals(perimeter).Count;

                if (numberOfSolutions > maximalNumberOfSolutionsFound)
                {
                    maximalNumberOfSolutionsFound = numberOfSolutions;
                    perimeterWithMostSolutions = perimeter;
                }
            }

            return perimeterWithMostSolutions;
        }
    }
}
