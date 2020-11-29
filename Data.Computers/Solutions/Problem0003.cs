using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0003 : IProblem
    {
        private readonly long NUMBER_TO_FACTOR_INTO_PRIMES = 600851475143;

        public long ComputeSolution()
        {
            var primeFactorsOfNumber = PrimeHelper.GetPrimeFactors(NUMBER_TO_FACTOR_INTO_PRIMES);
            return primeFactorsOfNumber.Max();
        }
    }
}