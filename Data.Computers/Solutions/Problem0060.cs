using System.Collections.Generic;
using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0060 : IProblem
    {
        // This is a bit arbitrary, but for 5 primes this is just enough to return the solution.
        // The highest prime of this group is 8389, so the upper bound is really tight in order to speed up computation speed.
        private readonly int UPPER_BOUND_OF_PRIMES = 8400;
        private readonly int REQUIRED_NUMBER_OF_PRIMES = 5;
        private readonly Dictionary<long, HashSet<long>> PRIMES_WITH_CANDIDATE_CONCATENATIONS = new Dictionary<long, HashSet<long>>();
        private Dictionary<HashSet<long>, HashSet<long>> PRIMES_GROUPED_BY_CONCATENATIONS = new Dictionary<HashSet<long>, HashSet<long>>();

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
            ComputeCandidateConcatenationPrimesForAllPrimesUpToUpperBound();
            ComputeLargerGroupsOfConcatenationPrimesRecursively();
            var groupsOfPrimesToCheck = PRIMES_GROUPED_BY_CONCATENATIONS.Keys;
            return groupsOfPrimesToCheck.Select(primes => primes.Sum()).Min();
        }

        private void ComputeLargerGroupsOfConcatenationPrimesRecursively()
        {
            int currentSizeOfGroups = 1;
            while (currentSizeOfGroups < REQUIRED_NUMBER_OF_PRIMES)
            {
                PRIMES_GROUPED_BY_CONCATENATIONS = ComputeConcatenationGroupsOneSizeLargerThanCurrentHighest();
                currentSizeOfGroups++;
            }
        }

        private Dictionary<HashSet<long>, HashSet<long>> ComputeConcatenationGroupsOneSizeLargerThanCurrentHighest()
        {
            var concatenationGroupsOneSizeLarger = new Dictionary<HashSet<long>, HashSet<long>>();
            foreach (HashSet<long> listOfPrimes in PRIMES_GROUPED_BY_CONCATENATIONS.Keys)
            {
                var primesWhichCanBeConcatenated = PRIMES_GROUPED_BY_CONCATENATIONS[listOfPrimes];
                foreach (long prime in primesWhichCanBeConcatenated)
                {
                    var intersection = primesWhichCanBeConcatenated.Intersect(PRIMES_WITH_CANDIDATE_CONCATENATIONS[prime]);
                    if (intersection.Count() >= 1 || primesWhichCanBeConcatenated.Count == 1)
                    {
                        var newPrimeList = new HashSet<long>(listOfPrimes) { prime };
                        concatenationGroupsOneSizeLarger.Add(newPrimeList, intersection.ToHashSet());
                    }
                }
            }
            return concatenationGroupsOneSizeLarger;
        }

        private void ComputeCandidateConcatenationPrimesForAllPrimesUpToUpperBound()
        {
            // If two different primes have sums which are 1 and 2 modulo 3,
            // then concatening them yields a number which sum is 0 modulo 3.
            // Hence this concatenation is divisble by 3, so not a prime.
            // Thus it suffices to consider these cases separately. 
            // Moreover note that the prime 3 can be contained in both groups.
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
            var listOfPrimesWhichCanBeConcatedWithPrime = new HashSet<long>();
            foreach (long otherPrime in primes)
            {
                if (AreConcatenationsPrime(prime, otherPrime))
                {
                    listOfPrimesWhichCanBeConcatedWithPrime.Add(otherPrime);
                }
            }
            PRIMES_WITH_CANDIDATE_CONCATENATIONS.Add(prime, listOfPrimesWhichCanBeConcatedWithPrime);
            PRIMES_GROUPED_BY_CONCATENATIONS.Add(new HashSet<long> { prime }, listOfPrimesWhichCanBeConcatedWithPrime);
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