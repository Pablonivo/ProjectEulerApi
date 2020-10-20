using System.Collections.Generic;

namespace Data.Computers
{
    public static class TriangleNumberHelper
    {
        public static long GetNthTriangleNumber(long n)
        {
            return n * (n + 1) / 2;
        }

        public static long GetFirstTriangleNumberWithAtLeastNDivisor(int requiredNumberOfDivisors)
        {
            int n = 1;
            var nthTriangleNumber = GetNthTriangleNumber(n);

            while (DivisorHelper.GetNumberOfDivisors(nthTriangleNumber) < requiredNumberOfDivisors)
            {
                n++;
                nthTriangleNumber = GetNthTriangleNumber(n);
            }

            return GetNthTriangleNumber(n);
        }

        public static List<long> GetListOfTriangleNumbersBelowMax(int max)
        {
            var triangleNumbersBelowMax = new List<long>();
            var n = 1;
            var nthTriangleNumber = GetNthTriangleNumber(n);

            while (nthTriangleNumber < max)
            {
                triangleNumbersBelowMax.Add(nthTriangleNumber);
                n++;
                nthTriangleNumber = GetNthTriangleNumber(n);
            }

            return triangleNumbersBelowMax;
        }

        // Note that T(1 + 2k) = H(1 + k), so every HexagonalNumber is a TriangleNumber
        // Proof: T(1 + 2k) = (1 + 2k)*(1 + 2k + 1) / 2 = (1 + 2k)*(1 + k),
        // and H(n + k) = (1 + k)*(2(1 + k) - 1) = (1 + k)*(1 + 2k)
        public static List<long> GetFirstNTriangleNumbersWhichAreAlsoPentagonalAndHexogonal(int count)
        {
            var listOfNumbersFound = new List<long>(); 
            long n = 1;

            while (count != 0)
            {
                var nthTriangleNumber = GetNthTriangleNumber(n);

                if (PentagonNumberHelper.IsPentagonalNumber(nthTriangleNumber))
                {
                    listOfNumbersFound.Add(nthTriangleNumber);
                    count--;
                }

                n += 2;
            }

            return listOfNumbersFound;
        }
    }
}
