using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Data.Computers.Solutions
{
    public class Problem0026 : IProblem
    {
        private readonly int UPPER_BOUND = 1000;

        public long ComputeSolution()
        {
            var lengthOfLongestCycle = 0;
            var numberWithLongestCycle = 0;
            var numberBelowUpperBound = Enumerable.Range(1, UPPER_BOUND - 1);
            foreach (int number in numberBelowUpperBound)
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

        // xx / 7 = q + r/7
        // 10 / 7 = 1 + 3/7
        // 30 / 7 = 4 + 2/7
        // 20 / 7 = 2 + 6/7
        // 60 / 7 = 8 + 4/7
        // 40 / 7 = 5 + 5/7
        // 50 / 7 = 7 + 1/7
        // We already computed 10 / 7, so 1/7 = 0.(142857)
        private BigInteger GetRecurringCycleOfFraction(int numerator, int denominator)
        {
            // Without loss of generality we assume that numerator < denominator.
            var recurringCycle = string.Empty;
            var listOfRemaindersAlreadyComputed = new List<int>();
            var (quotient, remainder) = UseLongDivision(numerator, denominator);
            while (!listOfRemaindersAlreadyComputed.Contains(remainder))
            {
                recurringCycle += quotient.ToString();
                listOfRemaindersAlreadyComputed.Add(remainder);
                (quotient, remainder) = UseLongDivision(remainder, denominator);
            }
            return BigInteger.Parse(recurringCycle);
        }

        private (int, int) UseLongDivision(int numerator, int denominator)
        {
            var quotient = numerator * 10 / denominator;
            var remainder = numerator * 10 % denominator;
            return (quotient, remainder);
        }
    }
}