using System;
using System.Collections.Generic;

namespace Data.Computers
{
    public static class PentagonNumberHelper
    {
        public static long GetNthPentagonalNumber(int n)
        {
            return n * (3 * n - 1) / 2;
        }

        // If x = n(3n−1)/2 => 2x = n(3n - 1) = 3n^2 - n => 3n^2 - n - 2x = 0 
        // Solving this quadratic equations yields:
        // D = b^2 - 4ac = 1 - (4 * 3 * -2x) = 1 + 24x
        // n = (1 - sqrt(1 + 24x))/6 or n = (1 + sqrt(1 + 24x))/6
        // x and n are positive integers > 0, so n = (1 + sqrt(1 + 24x))/6
        // So n is a pentagon number if 1 + 24x is a square number and sqrt(1 + 24x) == 5 mod 6.
        public static bool IsPentagonalNumber(long integer)
        {
            var numberToCheck = 1 + 24 * integer;
            return NumberHelper.IsSquare(numberToCheck) && Math.Sqrt(numberToCheck) % 6 == 5;  
        }

        public static long GetMinimalDistanceOfPentagonalNumbersForWhichSumAndDifferenceArePentagonal()
        {
            var foundPairOfDesiredPentagonalNumbers = false;
            var pentagonalNumbers = new List<long> { 1, 5 };
            var n = 2;

            while (!foundPairOfDesiredPentagonalNumbers)
            {
                n++;
                var nthPentagonalNumber = GetNthPentagonalNumber(n);

                foreach(long pentagonalNumber in pentagonalNumbers)
                {
                    if (IsPentagonalNumber(nthPentagonalNumber - pentagonalNumber) && IsPentagonalNumber(nthPentagonalNumber + pentagonalNumber))
                    {
                        return nthPentagonalNumber - pentagonalNumber;
                    }
                }

                pentagonalNumbers.Add(nthPentagonalNumber);
            }

            return 0;
        }
    }
}
