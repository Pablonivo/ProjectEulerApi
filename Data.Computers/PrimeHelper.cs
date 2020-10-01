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
                }
                else
                {
                    i++;
                }
            }

            return primeFactorList;
        }

        public static Dictionary<int, int> GetPrimeFactorization(int number)
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
    }
}
