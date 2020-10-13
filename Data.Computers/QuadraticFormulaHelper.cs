using System;
using System.Linq;

namespace Data.Computers
{
    public static class QuadraticFormulaHelper
    {
        private static Func<int, int> GetQuadraticFormule(int a, int b)
        {
            return n => n * n + a * n + b;
        }

        public static (int, int) GetCoefficientsForQuadraticExpressionWhichProducesMaximumNumberOfPrimes(int maxModulusOfCoefficients)
        {
            var longestSequenceOfPrimes = 0;
            var coefficientsForLongestSequence = (0, 0);

            foreach (int a in Enumerable.Range(-maxModulusOfCoefficients + 1, 2 * maxModulusOfCoefficients - 2))
            {
                foreach (int b in Enumerable.Range(1, maxModulusOfCoefficients))
                {
                    var quadraticFormula = GetQuadraticFormule(a, b);
                    var n = 0;

                    while (PrimeHelper.IsPrime(quadraticFormula(n)))
                    {
                        n++;
                    }

                    if (n > longestSequenceOfPrimes)
                    {
                        longestSequenceOfPrimes = n;
                        coefficientsForLongestSequence = (a, b);
                    }
                }
            }

            return coefficientsForLongestSequence;
        }
    }
}
