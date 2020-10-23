using System.Collections.Generic;
using System.Linq;

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

        private static long NextCollaztNumber(long n)
        {
            if (n % 2 == 0)
            {
                return NextCollatzNumberForEvenNumber(n);
            }
            else
            {
                return NextCollatzNumberForOddNumber(n);
            }
        }

        private static long NextCollatzNumberForEvenNumber(long n)
        {
            return n / 2;
        }

        private static long NextCollatzNumberForOddNumber(long n)
        {
            return 3 * n + 1;
        }

        public static long GetStartingNumberBelowMaxWithLongestSequence(int max)
        {
            var lengthOfSequence = new Dictionary<long, long>
            {
                [1] = 1
            };

            for (int i = 2; i < max; i++)
            {
                long lengthOfCurrentSequence = 1;
                var nextNumber = NextCollaztNumber(i);

                while (nextNumber != 1)
                {
                    if (lengthOfSequence.ContainsKey(nextNumber))
                    {
                        lengthOfCurrentSequence += lengthOfSequence[nextNumber];
                        break;
                    }

                    if (nextNumber % 2 == 0)
                    {
                        nextNumber = NextCollatzNumberForEvenNumber(nextNumber);
                        lengthOfCurrentSequence++;
                    }

                    else
                    {
                        nextNumber = NextCollatzNumberForOddNumber(nextNumber);
                        lengthOfCurrentSequence += 2;
                    }
                }

                lengthOfSequence.Add(i, lengthOfCurrentSequence);
            }

            var lengthOfLongestSequenceBelowMax = lengthOfSequence.Where(keyValue => keyValue.Key < max).Select(keyValue => keyValue.Value).Max();
            return lengthOfSequence.First(keyValue => keyValue.Value == lengthOfLongestSequenceBelowMax).Key;
        }
    }
}
