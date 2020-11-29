using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0011 : IProblem
    {
        private readonly int[,] GRID = TestData.TestData.Get20By20GridProblem11();
        private readonly int SIZE_OF_GRID = 20;
        private readonly int NUMBER_OF_ADJACENT_DIGITS = 4;

        public long ComputeSolution()
        {
            return GetLargestProductOf4AdjacentNumberInGrid(GRID);
        }

        private long GetLargestProductOf4AdjacentNumberInGrid(int[,] grid)
        {
            int largestHorizontalProduct = GetLargestHorizontalProduct(grid);
            int largestVerticalProduct = GetLargestVerticalProduct(grid);
            int largestDefaultDiagonalProduct = GetLargestDefaultDiagonalProduct(grid);
            int largestOtherDiagonalProduct = GetLargestOtherDiagonalProduct(grid);
            return new[] { largestHorizontalProduct, largestVerticalProduct, largestDefaultDiagonalProduct, largestOtherDiagonalProduct }.Max();
        }

        private int GetLargestHorizontalProduct(int[,] grid)
        {
            var largestProductFound = 0;
            for (int i = 0; i < SIZE_OF_GRID; i++)
            {
                for (int j = 0; j < SIZE_OF_GRID - NUMBER_OF_ADJACENT_DIGITS; j++)
                {
                    var currentProduct = grid[i, j] * grid[i, j + 1] * grid[i, j + 2] * grid[i, j + 3];
                    if (currentProduct > largestProductFound)
                    {
                        largestProductFound = currentProduct;
                    }
                }
            }
            return largestProductFound;
        }

        private int GetLargestVerticalProduct(int[,] grid)
        {
            var largestProductFound = 0;
            for (int i = 0; i < SIZE_OF_GRID - NUMBER_OF_ADJACENT_DIGITS; i++)
            {
                for (int j = 0; j < SIZE_OF_GRID; j++)
                {
                    var currentProduct = grid[i, j] * grid[i + 1, j] * grid[i + 2, j] * grid[i + 3, j];
                    if (currentProduct > largestProductFound)
                    {
                        largestProductFound = currentProduct;
                    }
                }
            }
            return largestProductFound;
        }

        private int GetLargestDefaultDiagonalProduct(int[,] grid)
        {
            var largestProductFound = 0;
            for (int i = 0; i < SIZE_OF_GRID - NUMBER_OF_ADJACENT_DIGITS; i++)
            {
                for (int j = 0; j < SIZE_OF_GRID - NUMBER_OF_ADJACENT_DIGITS; j++)
                {
                    var currentProduct = grid[i, j] * grid[i + 1, j + 1] * grid[i + 2, j + 2] * grid[i + 3, j + 3];
                    if (currentProduct > largestProductFound)
                    {
                        largestProductFound = currentProduct;
                    }
                }
            }
            return largestProductFound;
        }

        private int GetLargestOtherDiagonalProduct(int[,] grid)
        {
            var largestProductFound = 0;
            for (int i = 0; i < SIZE_OF_GRID - NUMBER_OF_ADJACENT_DIGITS; i++)
            {
                for (int j = NUMBER_OF_ADJACENT_DIGITS - 1; j < SIZE_OF_GRID; j++)
                {
                    var currentProduct = grid[i, j] * grid[i + 1, j - 1] * grid[i + 2, j - 2] * grid[i + 3, j - 3];
                    if (currentProduct > largestProductFound)
                    {
                        largestProductFound = currentProduct;
                    }
                }
            }
            return largestProductFound;
        }
    }
}