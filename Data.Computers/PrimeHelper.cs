using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Computers
{
    public static class PrimeHelper
    {
        public static bool IsPrime(long number)
        {
            if (number <= 1)
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

        public static bool IsCircularPrime(long number)
        {
            var numberToString = number.ToString();
            var lengthOfNumber = numberToString.Length;

            for (int i = 0; i < lengthOfNumber; i++)
            {
                numberToString = numberToString[1..lengthOfNumber] + numberToString.Substring(0, 1);
                number = int.Parse(numberToString);

                if (!IsPrime(number))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsTruncatablePrime(long number)
        {
            var numberToString = number.ToString();
            var lengthOfNumber = numberToString.Length;

            for (int i = 0; i <= lengthOfNumber - 1; i++)
            {
                var numberTruncatedFromTheLeft = int.Parse(numberToString.Substring(i));
                var numberTruncatedFromTheRight = int.Parse(numberToString.Substring(0, lengthOfNumber - i));

                if (!IsPrime(numberTruncatedFromTheLeft) || !IsPrime(numberTruncatedFromTheRight))
                {
                    return false;
                }
            }

            return true;
        }

        public static List<long> GetAllTruncatablePrimes()
        {
            var listOfPossibleRightTruncatablePrimes = new List<long>();
            var primesOf1Digit = new List<long> { 2, 3, 5, 7 };
            var listOfPossibleRightTruncatablePrimesToAdd = GetPossibleRightTruncatablePrimesWithOneMoreDigit(primesOf1Digit).Distinct().ToList();

            while (listOfPossibleRightTruncatablePrimesToAdd.Count() != 0)
            {
                listOfPossibleRightTruncatablePrimes.AddRange(listOfPossibleRightTruncatablePrimesToAdd);
                listOfPossibleRightTruncatablePrimesToAdd = GetPossibleRightTruncatablePrimesWithOneMoreDigit(listOfPossibleRightTruncatablePrimesToAdd);
            }

            return listOfPossibleRightTruncatablePrimes.Where(prime => IsTruncatablePrime(prime)).ToList();
        }

        private static List<long> GetPossibleRightTruncatablePrimesWithOneMoreDigit(List<long> truncatablePrimes)
        {
            var truncatableDigits = new List<int> { 1, 3, 7, 9 };
            var truncatablePrimesWithOneMoreDigit = new List<long>();

            foreach (int prime in truncatablePrimes)
            {
                foreach (int digitToAdd in truncatableDigits)
                {
                    var numberWithDigitToTheRight = (long)prime * 10 + digitToAdd;

                    if (IsPrime(numberWithDigitToTheRight))
                    {
                        truncatablePrimesWithOneMoreDigit.Add(numberWithDigitToTheRight);
                    }
                }
            }

            return truncatablePrimesWithOneMoreDigit;
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

        public static List<long> SieveOfEratosthenes(int max)
        {
            var isPrimeList = new bool[max + 1].Select(boolean => true).ToList();
            var primeList = new List<long>();

            for (int i = 2; i <= Math.Sqrt(max); i++){
                if (isPrimeList[i])
                {
                    for (int j = i * i; j <= max; j += i)
                    {
                        isPrimeList[j] = false;
                    }
                }
            }

            foreach(int i in Enumerable.Range(2, max - 2))
            {
                if (isPrimeList[i])
                {
                    primeList.Add(i);
                }
            }

            return primeList;
        }

        public static List<long> GetListOfCircularPrimesBelowMax(int max)
        {
            return SieveOfEratosthenes(max).Where(prime => IsCircularPrime(prime)).ToList();
        }
    }
}
