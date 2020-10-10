using System;
using System.Collections.Generic;

namespace Data.Computers
{
    public static class PrimeHelper
    {
        public static bool IsPrime(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int GetNthPrime(int number)
        {
            int i = 2;

            while (number != 1)
            {
                i++;

                if (IsPrime(i))
                {
                    number -= 1;
                }
            }

            return i;
        }

        public static List<long> GetPrimeFactors(long number)
        {
            var primeFactorList = new List<long>();
            long i = 2;

            while (number != 1)
            {
                if (number % i == 0)
                {
                    number /= i;
                    primeFactorList.Add(i);
                }
                else
                {
                    i++;
                }
            }

            return primeFactorList;
        }

        public static Dictionary<int, int> GetPrimeFactorization(long number)
        {
            var primeFactorization = new Dictionary<int, int>();
            int i = 2;

            while (number != 1)
            {
                if (number % i == 0)
                {
                    number /= i;
                    if (primeFactorization.ContainsKey(i))
                    {
                        primeFactorization[i] += 1;
                    }
                    else
                    {
                        primeFactorization.Add(i, 1);
                    }
                }
                else
                {
                    i++;
                }
            }

            return primeFactorization;
        }

        public static List<long> GetListOfPrimesUpTo(int max)
        {
            var listOfPrimes = new List<long>();

            if (max >= 2)
            {
                listOfPrimes.Add(2);
            }
            else
            {
                return listOfPrimes;
            }

            for (int i = 3; i < max; i += 2)
            {
                if (IsPrime(i))
                {
                    listOfPrimes.Add(i);
                }
            }

            return listOfPrimes;
        }
    }
}
