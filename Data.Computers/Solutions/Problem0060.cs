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
        private readonly Dictionary<int, List<int>> PRIMES_WITH_CANDIDATE_CONCATENATIONS = new Dictionary<int, List<int>>();
        private Dictionary<List<int>, List<int>> PRIMES_GROUPED_BY_CONCATENATIONS = new Dictionary<List<int>, List<int>>();

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

        private Dictionary<List<int>, List<int>> ComputeConcatenationGroupsOneSizeLargerThanCurrentHighest()
        {
            var concatenationGroupsOneSizeLarger = new Dictionary<List<int>, List<int>>();
            foreach (List<int> listOfPrimes in PRIMES_GROUPED_BY_CONCATENATIONS.Keys)
            {
                var primesWhichCanBeConcatenated = PRIMES_GROUPED_BY_CONCATENATIONS[listOfPrimes];
                foreach (var prime in primesWhichCanBeConcatenated)
                {
                    var intersection = primesWhichCanBeConcatenated.Intersect(PRIMES_WITH_CANDIDATE_CONCATENATIONS[prime]);
                    if (intersection.Count() >= 1 || primesWhichCanBeConcatenated.Count == 1)
                    {
                        var newPrimeList = new List<int>(listOfPrimes) { prime };
                        concatenationGroupsOneSizeLarger.Add(newPrimeList, intersection.ToList());
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
            // Note that 3 can belong to both of these groups, so it is also treated separately.
            var primes = PrimeHelper.SieveOfEratosthenes(UPPER_BOUND_OF_PRIMES).Select(prime => (int)prime);
            var firstPrimeGroup = primes.Where(prime => NumberHelper.SumOfDigits(prime) % 3 == 1);
            var secondPrimeGroup = primes.Where(prime => NumberHelper.SumOfDigits(prime) % 3 == 2);
            ComputeCandidateConcatenations(firstPrimeGroup.ToList());
            ComputeCandidateConcatenations(secondPrimeGroup.ToList());
            ComputeCandidateConcatenations(3, primes.ToList());
        }

        private void ComputeCandidateConcatenations(List<int> primes)
        {
            foreach (var prime in primes)
            {
                ComputeCandidateConcatenations(prime, primes);
            }
        }

        private void ComputeCandidateConcatenations(int prime, List<int> primes)
        {
            var listOfPrimesWhichCanBeConcatedWithPrime = new List<int>();
            foreach (var otherPrime in primes)
            {
                if (AreConcatenationsPrime(prime, otherPrime))
                {
                    listOfPrimesWhichCanBeConcatedWithPrime.Add(otherPrime);
                }
            }
            PRIMES_WITH_CANDIDATE_CONCATENATIONS.Add(prime, listOfPrimesWhichCanBeConcatedWithPrime);
            PRIMES_GROUPED_BY_CONCATENATIONS.Add(new List<int> { prime }, listOfPrimesWhichCanBeConcatedWithPrime);
        }

        private bool AreConcatenationsPrime(int a, int b)
        {
            return PrimeHelper.IsPrime(ConcatenateNumbers(a, b)) && PrimeHelper.IsPrime(ConcatenateNumbers(b, a));
        }

        private int ConcatenateNumbers(int a, int b)
        {
            return int.Parse(a.ToString() + b.ToString());
        }
    }
}