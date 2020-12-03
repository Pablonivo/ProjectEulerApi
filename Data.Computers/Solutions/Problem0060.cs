using System.Collections.Generic;
using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0060 : IProblem
    {
        // This is a bit arbitrary, but for 5 primes this is just enough to return the solution.
        private readonly int UPPER_BOUND_OF_PRIMES = 10000;
        private readonly int REQUIRED_NUMBER_OF_PRIMES = 5;
        private readonly Dictionary<List<long>, List<long>> PRIMES_GROUPED_BY_CONCATENATIONS = new Dictionary<List<long>, List<long>>();

        public Problem0060(int upperBoundOfPrimes, int requiredNumberOfPrimes)
        {
            UPPER_BOUND_OF_PRIMES = upperBoundOfPrimes;
            REQUIRED_NUMBER_OF_PRIMES = requiredNumberOfPrimes;
        }

        public Problem0060()
        {

        }

        public long ComputeSolution()
        {
            ComputeCandidateConcatenaionPrimesForAllPrimesUpToUpperBound();
            int currentSizeOfGroups = 1;
            while (currentSizeOfGroups < REQUIRED_NUMBER_OF_PRIMES)
            {
                Dictionary<List<long>, List<long>> tempDictionary = ComputeConcatenationGroupsOneSizeLargerThanCurrentHighest(currentSizeOfGroups);
                foreach (List<long> key in tempDictionary.Keys)
                {
                    PRIMES_GROUPED_BY_CONCATENATIONS.Add(key, tempDictionary[key]);
                }
                currentSizeOfGroups++;
            }
            var groupsOfPrimesToCheck = PRIMES_GROUPED_BY_CONCATENATIONS.Keys.Where(group => group.Count == REQUIRED_NUMBER_OF_PRIMES);
            return groupsOfPrimesToCheck.Select(primes => primes.Sum()).Min();
        }

        private Dictionary<List<long>, List<long>> ComputeConcatenationGroupsOneSizeLargerThanCurrentHighest(int currentSizeOfGroups)
        {
            var keysOfGroupsOfCurrentSize = PRIMES_GROUPED_BY_CONCATENATIONS.Keys.Where(key => key.Count() == currentSizeOfGroups);
            var concatenationGroupsOneSizeLarger = new Dictionary<List<long>, List<long>>();
            foreach (List<long> listOfPrimes in keysOfGroupsOfCurrentSize)
            {
                foreach (long prime in PRIMES_GROUPED_BY_CONCATENATIONS[listOfPrimes])
                {
                    var keyOfPrime = PRIMES_GROUPED_BY_CONCATENATIONS.Keys.Single(list => list.Count() == 1 && list.Single() == prime);
                    var intersection = PRIMES_GROUPED_BY_CONCATENATIONS[listOfPrimes].Intersect(PRIMES_GROUPED_BY_CONCATENATIONS[keyOfPrime]);
                    if (intersection.Count() >= 1 || PRIMES_GROUPED_BY_CONCATENATIONS[listOfPrimes].Count == 1)
                    {
                        var newPrimeList = new List<long>(listOfPrimes) { prime };
                        concatenationGroupsOneSizeLarger.Add(newPrimeList, intersection.ToList());
                    }
                }
            }
            return concatenationGroupsOneSizeLarger;
        }

        private void ComputeCandidateConcatenaionPrimesForAllPrimesUpToUpperBound()
        {
            // If two different primes have sums which are 1 and 2 modulo 3,
            // then concatening them yields a number which sum is 0 modulo 3.
            // Hence this concatenation is divisble by 3, so not a prime.
            // Thus it suffices to consider these cases separately. 
            // Moreover not that the prime 3 can be contained in both groups.
            var primes = PrimeHelper.SieveOfEratosthenes(UPPER_BOUND_OF_PRIMES);
            var firstPrimeGroup = primes.Where(prime => NumberHelper.SumOfDigits(prime) % 3 == 1).Append(3);
            var secondPrimeGroup = primes.Where(prime => NumberHelper.SumOfDigits(prime) % 3 == 2).Append(3);
            ComputeCandidateConcatenations(primes);
        }

        private void ComputeCandidateConcatenations(List<long> primes)
        {
            foreach (long prime in primes)
            {
                ComputeCandidateCatenaions(prime, primes);
            }
        }

        private void ComputeCandidateCatenaions(long prime, List<long> primes)
        {
            var listOfPrimesWhichCanBeConcatedWithPrime = new List<long>();
            foreach (long otherPrime in primes)
            {
                if (AreConcatenationsPrime(prime, otherPrime))
                {
                    listOfPrimesWhichCanBeConcatedWithPrime.Add(otherPrime);
                }
            }
            PRIMES_GROUPED_BY_CONCATENATIONS.Add(new List<long> { prime }, listOfPrimesWhichCanBeConcatedWithPrime);
        }

        private bool AreConcatenationsPrime(long a, long b)
        {
            return PrimeHelper.IsPrime(ConcatenateNumbers(a, b)) && PrimeHelper.IsPrime(ConcatenateNumbers(b, a));
        }

        private int ConcatenateNumbers(long a, long b)
        {
            return int.Parse(a.ToString() + b.ToString());
        }
    }
}