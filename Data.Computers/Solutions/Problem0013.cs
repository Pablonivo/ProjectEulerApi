using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Data.Computers.Solutions
{
    public class Problem0013 : IProblem
    {
        private readonly int NUMBER_OF_FIRST_N_DIGITS = 10;
        private readonly List<BigInteger> INTEGERS = TestData.TestData.Get100NumbersWith50DigitsProblem13();

        public long ComputeSolution()
        {
            var sum = Sum(INTEGERS);
            return GetFirstDigits(sum);
        }

        private BigInteger Sum(List<BigInteger> integers)
        {
            return integers.Aggregate(BigInteger.Add);
        }

        private long GetFirstDigits(BigInteger integer)
        {
            return long.Parse(integer.ToString().Substring(0, NUMBER_OF_FIRST_N_DIGITS));
        }
    }
}