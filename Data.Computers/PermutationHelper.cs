using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Data.Computers
{
    public static class PermutationHelper
    {
        public static string GetNthLexiographicPermutation(BigInteger desiredIndex, List<char> orderedCharacters)
        {
            var numberOfCharacters = orderedCharacters.Count;

            if (numberOfCharacters == 1)
            {
                if (desiredIndex != 1)
                {
                    throw new ArgumentOutOfRangeException("The list of characters has length 1, while the desired index was not equal to 1");
                }

                return orderedCharacters.Single().ToString();
            }

            BigInteger currentIndex = 0;
            int count = 0;

            while (currentIndex + NumberHelper.Factorial(numberOfCharacters - 1) < desiredIndex)
            {
                currentIndex += NumberHelper.Factorial(numberOfCharacters - 1);
                count += 1;
            }

            var characterToUse = orderedCharacters[count];
            var orderedDigitsWithoutDigitUsed = orderedCharacters.Where(character => character != characterToUse).ToList();

            return characterToUse.ToString() + GetNthLexiographicPermutation(desiredIndex - currentIndex, orderedDigitsWithoutDigitUsed);
        }
    }
}
