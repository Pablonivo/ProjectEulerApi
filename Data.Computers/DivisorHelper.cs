using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Computers
{
    public static class DivisorHelper
    {
        public static int GetNumberOfDivisors(long n)
        {
            var numberOfDivisors = 1;
            var primeFactorization = PrimeHelper.GetPrimeFactorization(n);

            foreach (int key in primeFactorization.Keys)
            {
                numberOfDivisors *= primeFactorization[key] + 1;
            }

            return numberOfDivisors;
        }

        public static List<int> GetListOfProperDivisors(int n)
        {
            var listOfProperDivisors = new List<int> { 1 };

            if (n <= 1)
            {
                return listOfProperDivisors;
            }

            foreach (int potentialDivisor in Enumerable.Range(2, (int)Math.Sqrt(n) - 1))
            {
                if (n % potentialDivisor == 0)
                {
                    listOfProperDivisors.Add(potentialDivisor);

                    if (potentialDivisor * potentialDivisor != n)
                    {
                        listOfProperDivisors.Add(n / potentialDivisor);
                    }
                }
            }

            return listOfProperDivisors;
        }
    }
}
