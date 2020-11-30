using System.Numerics;

namespace Data.Computers.Solutions
{
    public class Problem0016 : IProblem
    {
        private readonly int BASE = 2;
        private readonly int EXPONENT = 1000;

        public long ComputeSolution()
        {
            BigInteger number = BigInteger.Pow(BASE, EXPONENT);
            return NumberHelper.SumOfDigits(number);
        }
    }
}