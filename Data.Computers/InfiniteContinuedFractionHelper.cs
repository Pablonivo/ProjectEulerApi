using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Data.Entities;

namespace Test.Data.Computers
{
    public static class InfiniteContinuedFractionHelper
    {
        public static List<Fraction> FirstNIterationOfSquareRootOfTwo(int n)
        {
            var startingNumerator = 3;
            var startingDenominator = 2;
            var iterations = new List<Fraction> { new Fraction(startingNumerator, startingDenominator) };

            if (n <= 1)
            {
                return iterations;
            }

            Dictionary<int, BigInteger> numerators = new Dictionary<int, BigInteger>
            {
                { 1, startingNumerator }
            };
            Dictionary<int, BigInteger> denominator = new Dictionary<int, BigInteger>
            {
                { 1, startingDenominator }
            };

            foreach (int i in Enumerable.Range(2, n - 1))
            {
                var numeratorOfCurrentIteration = numerators[i - 1] + 2 * denominator[i - 1];
                var denominatorOfCurrentIteration = numerators[i - 1] + denominator[i - 1];

                numerators.Add(i, numeratorOfCurrentIteration);
                denominator.Add(i, denominatorOfCurrentIteration);
                iterations.Add(new Fraction(numeratorOfCurrentIteration, denominatorOfCurrentIteration));
            }

            return iterations;
        }

        public static List<Fraction> FirstNIterationOfE(int n)
        {
            var startingNumerator = 2;
            var startingDenominator = 1;
            var iterations = new List<Fraction> { new Fraction(startingNumerator, startingDenominator) };

            if (n <= 1)
            {
                return iterations;
            }

            Dictionary<int, BigInteger> numerators = new Dictionary<int, BigInteger>
            {
                { 1, 2 },
                { 2,  3}
            };
            Dictionary<int, BigInteger> denominator = new Dictionary<int, BigInteger>
            {
                { 1, 1 },
                { 2, 1 }
            };
            iterations.Add(new Fraction(3, 1));

            foreach (int i in Enumerable.Range(3, n - 2))
            {
                BigInteger numeratorOfCurrentIteration;
                BigInteger denominatorOfCurrentIteration;

                if (i % 3 == 0)
                {
                    var multiplier = 2 * (i / 3);
                    numeratorOfCurrentIteration = multiplier * numerators[i - 1] + numerators[i - 2];
                    denominatorOfCurrentIteration = multiplier * denominator[i - 1] + denominator[i - 2];
                } else {
                    numeratorOfCurrentIteration =  numerators[i - 1] + numerators[i - 2];
                    denominatorOfCurrentIteration =  denominator[i - 1] + denominator[i - 2];
                }

                numerators.Add(i, numeratorOfCurrentIteration);
                denominator.Add(i, denominatorOfCurrentIteration);
                iterations.Add(new Fraction(numeratorOfCurrentIteration, denominatorOfCurrentIteration));
            }

            return iterations;
        }
    }
}
