using System.Collections.Generic;

namespace Data.Computers
{
    public static class PrimeHelper
    {
        public static List<long> GetPrimesFactors(long number)
        {
            var primeFactorList = new List<long>();
            long i = 2;

            while (number != 1)
            {
                if (number % i == 0)
                {
                    number /= i;
                    primeFactorList.Add(i);
                } else
                {
                    i++;
                }
            }

            return primeFactorList;
        }
    }
}
