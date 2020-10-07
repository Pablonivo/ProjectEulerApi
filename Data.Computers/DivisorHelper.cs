namespace Data.Computers
{
    public static class DivisorHelper
    {
        public static int GetNumberOfDivisors(long n)
        {
            var numberOfDivisors = 1;
            var primeFactorization = PrimeHelper.GetPrimeFactorization(n);
            
            foreach(int key in primeFactorization.Keys)
            {
                numberOfDivisors *= primeFactorization[key] + 1;
            }

            return numberOfDivisors;
        }
    }
}
