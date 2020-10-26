using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static List<long> PrimesInFamilyByReplacingDigitsBySameNumber(long prime, List<int> digitsToReplace)
        {
            var primesInFamily = new List<long>();
            var numbersFrom0To9 = Enumerable.Range(0, 10).ToList();
            var primeAsString = prime.ToString();

            foreach (int number in numbersFrom0To9)
            {
                var stringBuilder = new StringBuilder(primeAsString);
                
                foreach (int digitToReplace in digitsToReplace)
                {
                    stringBuilder.Remove(digitToReplace - 1, 1);
                    stringBuilder.Insert(digitToReplace - 1, number.ToString());
                }

                var potentialPrime = long.Parse(stringBuilder.ToString());
                if (potentialPrime.ToString().Length == primeAsString.Length && IsPrime(potentialPrime))
                {
                    primesInFamily.Add(potentialPrime);
                }
            }

            return primesInFamily;
        }

        public static int MaximumSizeOfFamilyByReplacingSomeDigitsBySameNumber(long prime)
        {
            var maximumSize = 0;

            // We do not consider prime which consist of only 1 digit.
            if (prime < 10)
            {
                return maximumSize;
            }

            var primeLength = prime.ToString().Length;
            // The last digit cannot be replaced, because a prime larger than 2 never ends with an even number.
            var indicesOfDigits = Enumerable.Range(1, primeLength - 1).ToList();
            var subsetsOfIndicesTotry = SubsetHelper.AllNonEmptySubsets(indicesOfDigits);

            foreach (List<int> subset in subsetsOfIndicesTotry)
            {
                var primesInFamily = PrimesInFamilyByReplacingDigitsBySameNumber(prime, subset);
                var numberOfPrimesInFamily = primesInFamily.Count;

                if (numberOfPrimesInFamily > maximumSize && primesInFamily.Contains(prime))
                {
                    maximumSize = numberOfPrimesInFamily;
                }
            }

            return maximumSize;
        }

        public static long FirstPrimeWhichHasDesiredSizeOfFamilyByReplacingSomeDigitsBySameNumber(int desiredSizeOfFamily)
        {
            // This is a bit arbitrary, but the solution for a familiy size of 8 is below 130000.
            // Initially this upper bound was higher, but to speed up computation time the bound is lowered.
            var upperBoundPrimes = 130000;
            var primes = SieveOfEratosthenes(upperBoundPrimes);

            if (desiredSizeOfFamily >= 8)
            {
                // We know that the smallest family having seven primes has 56003 as lowest prime.
                // Hence when looking for a family of size 8 we do not have to check for primes below 56003.
                primes = primes.Where(prime => prime > 56003).ToList();
            }

            foreach (long prime in primes)
            {
                if (MaximumSizeOfFamilyByReplacingSomeDigitsBySameNumber(prime) == desiredSizeOfFamily)
                {
                    return prime;
                }
            }

            return 0;
        }
    }
}
