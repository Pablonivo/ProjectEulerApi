using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0010 : IProblem
    {
        private readonly int UPPER_BOUND = 2000000;

        public long ComputeSolution()
        {
            return PrimeHelper.SieveOfEratosthenes(UPPER_BOUND).Sum();
        }
    }
}