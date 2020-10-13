using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Data.Computers
{
    public class FractionHelper
    {
        // xx / 7 = q + r/7
        // 10 / 7 = 1 + 3/7
        // 30 / 7 = 4 + 2/7
        // 20 / 7 = 2 + 6/7
        // 60 / 7 = 8 + 4/7
        // 40 / 7 = 5 + 5/7
        // 50 / 7 = 7 + 1/7
        // We already computed 10 / 7, so 1/7 = 0.(142857)
        public static BigInteger GetRecurringCycleOfFraction(int numerator, int denominator)
        {
            // Without loss of generality we assume that numerator < denominator.
            var recurringCycle = string.Empty;
            var listOfRemaindersAlreadyComputed = new List<int>();
            var quotient = numerator * 10 / denominator;
            var remainder = numerator * 10 % denominator;

            while (!listOfRemaindersAlreadyComputed.Contains(remainder))
            {
                recurringCycle += quotient.ToString();
                listOfRemaindersAlreadyComputed.Add(remainder);

                quotient = remainder * 10 / denominator;
                remainder = remainder * 10 % denominator;
            }

            return BigInteger.Parse(recurringCycle);
        }

        public static int GetLongestRecurringCycleFor1OverDBelowMax(int maximalDenominator)
        {
            var lengthOfLongestCycle = 0;
            var numberWithLongestCycle = 0;
            var numberBelowMax = Enumerable.Range(1, maximalDenominator - 1);

            foreach(int number in numberBelowMax)
            {
                var lengthOfCurrentCycle = GetRecurringCycleOfFraction(1, number).ToString().Length;

                if (lengthOfCurrentCycle > lengthOfLongestCycle)
                {
                    lengthOfLongestCycle = lengthOfCurrentCycle;
                    numberWithLongestCycle = number;
                }
            }

            return numberWithLongestCycle;
        }
    }
}
