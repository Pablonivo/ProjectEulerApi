namespace Data.Computers.Solutions
{
    public class Problem0012 : IProblem
    {
        private readonly int LOWER_BOUND_NUMBER_OF_DIVISORS = 500;

        public Problem0012(int lowerBoundNumbersOfDivisors)
        {
            LOWER_BOUND_NUMBER_OF_DIVISORS = lowerBoundNumbersOfDivisors;
        }

        public Problem0012()
        {

        }

        public long ComputeSolution()
        {
            return GetFirstTriangleNumberWithAtLeastNDivisor(LOWER_BOUND_NUMBER_OF_DIVISORS);
        }

        private long GetFirstTriangleNumberWithAtLeastNDivisor(int requiredNumberOfDivisors)
        {
            int n = 1;
            var nthTriangleNumber = TriangleNumberHelper.GetNthTriangleNumber(n);
            while (DivisorHelper.GetNumberOfDivisors(nthTriangleNumber) < requiredNumberOfDivisors)
            {
                n++;
                nthTriangleNumber = TriangleNumberHelper.GetNthTriangleNumber(n);
            }
            return nthTriangleNumber;
        }
    }
}