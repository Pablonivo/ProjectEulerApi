namespace Data.Computers
{
    public static class TriangleNumberHelper
    {
        public static long GetNthTriangleNumber(int n)
        {
            return n * (n + 1) / 2;
        }

        public static long GetFirstTriangleNumberWithAtLeastNDivisor(int requiredNumberOfDivisors)
        {
            int n = 1;
            long nthTriangleNumber = GetNthTriangleNumber(n);

            while (DivisorHelper.GetNumberOfDivisors(nthTriangleNumber) < requiredNumberOfDivisors)
            {
                n++;
                nthTriangleNumber = GetNthTriangleNumber(n);
            }

            return GetNthTriangleNumber(n);
        }
    }
}
