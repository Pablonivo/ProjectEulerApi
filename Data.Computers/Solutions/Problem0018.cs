using System;

namespace Data.Computers.Solutions
{
    public class Problem0018 : IProblem
    {
        private readonly int [,] NUMBER_TRIANGLE = TestData.TestData.TriangleProblem18();

        public Problem0018(int[,] numberTriangle)
        {
            NUMBER_TRIANGLE = numberTriangle;
        }

        public Problem0018()
        {

        }

        public long ComputeSolution()
        {
            return MaximalPathOfNumberTriangle(NUMBER_TRIANGLE);
        }

        private long MaximalPathOfNumberTriangle(int[,] triangleGrid)
        {
            var numberOfRows = (int)Math.Sqrt(triangleGrid.Length);
            for (int i = numberOfRows - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    triangleGrid[i, j] += Math.Max(triangleGrid[i + 1, j], triangleGrid[i + 1, j + 1]);
                }
            }
            return triangleGrid[0, 0];
        }
    }
}