using System.Collections.Generic;
using System.Linq;
using Data.Entities;

namespace Test.Data.Computers
{
    public static class InfiniteContinuedFractionHelper
    {
        public static List<Fraction> FirstNIterationOfSquareRootOfTwo(int n)
        {
            var iterations = new List<Fraction>();

            var integer = 1;
            Fraction fractionalPart = 2;
            iterations.Add(integer + 1 / fractionalPart);

            if (n != 1)
            {
                foreach (int i in Enumerable.Range(1, n - 1))
                {
                    fractionalPart = 2 + 1 / fractionalPart;
                    iterations.Add(integer + 1 / fractionalPart);
                }
            }

            return iterations;
        }
    }
}
