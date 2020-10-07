namespace Data.Computers
{
    public static class CollatzSequenceHelper
    {
        public static int GetLengthOfCollatzSequenceForStartingNumber(long n)
        {
            int lengthOfSequence = 1;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    lengthOfSequence++;
                } 
                else
                {
                    n = (3 * n + 1) / 2;
                    lengthOfSequence += 2;
                }
            }

            return lengthOfSequence;
        }

        public static int GetStartingNumberBelowMaxWithLongestSequence(int max)
        {
            var startingNumberWithLongestChain = 0;
            var lengthOfLongestChain = 0;

            for (int i = (max - 1) / 2; i < max; i++){
                var lengthOfCurrentSequence = GetLengthOfCollatzSequenceForStartingNumber(i);
                if (lengthOfCurrentSequence > lengthOfLongestChain)
                {
                    lengthOfLongestChain = lengthOfCurrentSequence;
                    startingNumberWithLongestChain = i;
                }
            }

            return startingNumberWithLongestChain;
        }
    }
}
