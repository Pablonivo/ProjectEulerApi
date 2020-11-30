using System.Collections.Generic;

namespace Data.Computers.Solutions
{
    public class Problem0014 : IProblem
    {
        private readonly int UPPER_BOUND = 1000000;
        private readonly Dictionary<long, long> SEQUENCE_LENGTH_FOR_STARTING_NUMBER = new Dictionary<long, long>();

        public Problem0014(int upperBound)
        {
            UPPER_BOUND = upperBound;
        }

        public Problem0014()
        {

        }

        public long ComputeSolution()
        {
            ComputeSequenceLengthForAllStartingNumbersBelowUpperBound(UPPER_BOUND);
            return GetStartingValueWithLongestSequence();
        }

        private void ComputeSequenceLengthForAllStartingNumbersBelowUpperBound(int upperBound)
        {
            SEQUENCE_LENGTH_FOR_STARTING_NUMBER.Add(1, 1);
            for (int i = 2; i < upperBound; i++)
            {
                long lengthForCurrentStartingNumber = ComputeLengthForStartingNumber(i);
                SEQUENCE_LENGTH_FOR_STARTING_NUMBER.Add(i, lengthForCurrentStartingNumber);
            }
        }

        private long ComputeLengthForStartingNumber(int startingNumber)
        {
            long lengthOfCurrentSequence = 1;
            var nextNumber = NextCollaztNumber(startingNumber);
            while (nextNumber != 1)
            {
                if (SEQUENCE_LENGTH_FOR_STARTING_NUMBER.ContainsKey(nextNumber))
                {
                    lengthOfCurrentSequence += SEQUENCE_LENGTH_FOR_STARTING_NUMBER[nextNumber];
                    break;
                }
                nextNumber = NextCollaztNumber(nextNumber);
                lengthOfCurrentSequence++;
            }
            return lengthOfCurrentSequence;
        }

        private long GetStartingValueWithLongestSequence()
        {
            long startingValueWithLongestSequence = 1;
            long lengthOfLongestSequence = 1;
            foreach (long startingNumber in SEQUENCE_LENGTH_FOR_STARTING_NUMBER.Keys)
            {
                var sequenceLength = SEQUENCE_LENGTH_FOR_STARTING_NUMBER[startingNumber];
                if (sequenceLength > lengthOfLongestSequence)
                {
                    lengthOfLongestSequence = sequenceLength;
                    startingValueWithLongestSequence = startingNumber;
                }
            }
            return startingValueWithLongestSequence;
        }

        private static long NextCollaztNumber(long n)
        {
            if (n % 2 == 0)
            {
                return n / 2;
            }
            else
            {
                return 3 * n + 1;
            }
        }
    }
}