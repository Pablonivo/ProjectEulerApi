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
            // TODO: Consider cases {3} + 1 mod 3 {3} + and 2 mod 3 differently (a concated b => both are same mod 3).
            var primes = PrimeHelper.SieveOfEratosthenes(UPPER_BOUND_OF_PRIMES);
            foreach (long prime in primes)
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
            var keysOfSinglePrimes = PRIMES_GROUPED_BY_CONCATENATIONS.Keys.Where(key => PRIMES_GROUPED_BY_CONCATENATIONS[key].Count() == 1);
            int currentSizeOfGroups = 1;
            while (currentSizeOfGroups < REQUIRED_NUMBER_OF_PRIMES)
            {
                var keysOfGroupsOfCurrentSize = PRIMES_GROUPED_BY_CONCATENATIONS.Keys.Where(key => key.Count() == currentSizeOfGroups);
                var tempDictionary = new Dictionary<List<long>, List<long>>();
                foreach (List<long> listOfPrimes in keysOfGroupsOfCurrentSize)
                {
                    foreach (long prime in PRIMES_GROUPED_BY_CONCATENATIONS[listOfPrimes])
                    {
                        var keyOfPrime = PRIMES_GROUPED_BY_CONCATENATIONS.Keys.Single(list => list.Count() == 1 && list.Single() == prime);
                        var intersection = PRIMES_GROUPED_BY_CONCATENATIONS[listOfPrimes].Intersect(PRIMES_GROUPED_BY_CONCATENATIONS[keyOfPrime]);
                        if (intersection.Count() >= 1 || PRIMES_GROUPED_BY_CONCATENATIONS[listOfPrimes].Count == 1)
                        {
                            var newPrimeList = new List<long>(listOfPrimes) { prime };
                            tempDictionary.Add(newPrimeList, intersection.ToList());
                        }
                    }
                }
                foreach (List<long> key in tempDictionary.Keys)
                {
                    PRIMES_GROUPED_BY_CONCATENATIONS.Add(key, tempDictionary[key]);
                }
                currentSizeOfGroups++;
            }
            var groupsOfPrimesToCheck = PRIMES_GROUPED_BY_CONCATENATIONS.Keys.Where(group => group.Count == REQUIRED_NUMBER_OF_PRIMES);
            return groupsOfPrimesToCheck.Select(primes => primes.Sum()).Min();
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