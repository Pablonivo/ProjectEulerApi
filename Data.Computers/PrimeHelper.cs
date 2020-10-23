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

            for (int i = 2; i <= Math.Sqrt(max); i++)
            {
                if (isPrimeList[i])
                {
                    for (int j = i * i; j <= max; j += i)
                    {
                        isPrimeList[j] = false;
                    }
                }
            }

            foreach (int i in Enumerable.Range(2, max - 2))
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

        public static long GetFirstCounterExampleGoldbachsOtherConjecture()
        {
            int n = 9;

            while (IsPrime(n) || CanBeWrittenAsSumOfPrimeAndTwiceASquare(n))
            {
                n += 2;
            }

            return n;
        }

        public static bool CanBeWrittenAsSumOfPrimeAndTwiceASquare(long integer)
        {
            int i = 1;
            var twiceASquare = 2 * i * i;

            while (twiceASquare < integer)
            {
                if (IsPrime(integer - twiceASquare))
                {
                    return true;
                }

                i++;
                twiceASquare = 2 * i * i;
            }

            return false;
        }

        public static long GetFirstNumberOfConsecutiveNumbersToHaveMDistinctPrimeFactors(int consecutiveNumbers, int numberOfDesiredDistinctPrimeFactors)
        {
            // This limit is a bit arbitrary, and needs to be increased for more complex searches.
            // However, it is required for the sieve (to speed up overall computation time).
            var limit = 1000000;
            var sievedNumbers = SieveWithNumberOfDistinctPrimeFactors(limit);

            for (int i = 2; i < int.MaxValue; i++)
            {
                var range = Enumerable.Range(i, consecutiveNumbers);

                if (range.All(numberInRange => sievedNumbers[numberInRange] == numberOfDesiredDistinctPrimeFactors))
                {
                    return i;
                }
            }

            return 0;
        }

        public static List<int> SieveWithNumberOfDistinctPrimeFactors(int max)
        {
            var sievedList = new int[max + 1].Select(number => 0).ToList();

            for (int i = 2; i <= Math.Sqrt(max); i++)
            {
                if (sievedList[i] == 0)
                {
                    for (int j = 2*i; j <= max; j += i)
                    {
                        sievedList[j] += 1;
                    }
                }
            }

            return sievedList;
        }

        public static Dictionary<long, List<long>> ArithmeticPrimePermutationsWith4Digits()
        {
            var listOfArithmeticPrimePermutationsWith4Digits = new Dictionary<long, List<long>>();
            var max = 9999;
            var primeList = SieveOfEratosthenes(max).Where(prime => prime >= 1000).ToList();

            foreach (long currentPrime in primeList)
            {
                var permutationsOfPrime = primeList.FindAll(prime => NumberHelper.AreNumbersPermutations(prime, currentPrime)).ToList();

                if (permutationsOfPrime.Count >= 3)
                {
                    var arithmeticSequence = NumberHelper.GetArithmeticSequenceFromList(permutationsOfPrime);
                    
                    if (arithmeticSequence.Count > 0 && !listOfArithmeticPrimePermutationsWith4Digits.ContainsKey(arithmeticSequence[0]))
                    {
                        listOfArithmeticPrimePermutationsWith4Digits.Add(arithmeticSequence[0], arithmeticSequence);
                    }
                }
            }

            return listOfArithmeticPrimePermutationsWith4Digits;
        }

        public static long PrimeBelowMaxWhichCanBeWrittenAsSumOfMostConsectivePrimes(int max)
        {
            long sumWithMostConsecutivePrimes = 2;
            var numberOfMostConsecutivePrimes = 1;
            var primeList = SieveOfEratosthenes(max);

            // We assume that the highest prime used in the sum cannot be larger than 66% of the highest primes below the max. 
            // This is a rather crude estimation (and it's safer to just consider all the primes).
            // However considering all primes would make this run slower, and we would need to make sure the indices do not exceed the prime count.
            var numberOfPrimesToLookAt = primeList.Count / 3; 

            for (int i = 0; i <= numberOfPrimesToLookAt; i++)
            {
                var rangeOfIndices = Enumerable.Range(i, numberOfMostConsecutivePrimes).ToList();
                long currentSumOfConsecutivePrimes = rangeOfIndices.Select(index => primeList[index]).Sum();
                int currentNumberOfPrimesUsed = numberOfMostConsecutivePrimes;
                int j = i + numberOfMostConsecutivePrimes;

                while (j < numberOfPrimesToLookAt && currentSumOfConsecutivePrimes + primeList[j] < max)
                {
                    currentSumOfConsecutivePrimes += primeList[j];
                    currentNumberOfPrimesUsed++;

                    if (IsPrime(currentSumOfConsecutivePrimes))
                    {
                        sumWithMostConsecutivePrimes = currentSumOfConsecutivePrimes;
                        numberOfMostConsecutivePrimes = currentNumberOfPrimesUsed;
                    }

                    j++;
                }
            }

            return sumWithMostConsecutivePrimes;
        }
    }
}
