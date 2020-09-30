using System.Linq;

namespace Data.Computers
{
    public static class SolutionComputer
    {
        public static int GetSolutionOfProblem1()
        {
            var max = 1000;
            var multiplesOfThree = NumberHelper.GetMultiplesOfNumberBelowMax(3, max);
            var multiplesOfFive = NumberHelper.GetMultiplesOfNumberBelowMax(5, max);

            var multiplesOfThreeAndFiveBelowMax = multiplesOfThree.Union(multiplesOfFive);

            return multiplesOfThreeAndFiveBelowMax.Sum();
        }

        public static int GetSolutionOfProblem2()
        {
            var max = 4000000;
            return FibonacciHelper.GetFibonacciListBelowMax(max).Where(x => x % 2 == 0).Sum();
        }
    }
}
