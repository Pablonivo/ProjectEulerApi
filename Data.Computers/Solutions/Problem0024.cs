using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Data.Computers.Solutions
{
    public class Problem0024 : IProblem
    {
        private readonly int DESIRED_INDEX = 1000000;
        private readonly List<char> LIST_OF_CHARACTERS_TO_USE = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public long ComputeSolution()
        {
            return long.Parse(GetNthLexiographicPermutation(DESIRED_INDEX, LIST_OF_CHARACTERS_TO_USE));
        }

        private string GetNthLexiographicPermutation(BigInteger desiredIndex, List<char> orderedCharacters)
        {
            var numberOfCharacters = orderedCharacters.Count;
            if (numberOfCharacters == 1)
            {
                return ReturnCharacterIfDesiredIndexIs1(desiredIndex, orderedCharacters);
            }
            BigInteger currentIndex = 0;
            int indexOfCharacterToUseNext = 0;
            var numberOfWaysOtherCharacterCanBeOrderedWhenOneIsFixed = FactorialHelper.Factorial(numberOfCharacters - 1);
            while (currentIndex + numberOfWaysOtherCharacterCanBeOrderedWhenOneIsFixed < desiredIndex)
            {
                currentIndex += numberOfWaysOtherCharacterCanBeOrderedWhenOneIsFixed;
                indexOfCharacterToUseNext += 1;
            }
            var characterToUse = orderedCharacters[indexOfCharacterToUseNext];
            var orderedDigitsWithoutDigitUsed = orderedCharacters.Where(character => character != characterToUse).ToList();
            return characterToUse.ToString() + GetNthLexiographicPermutation(desiredIndex - currentIndex, orderedDigitsWithoutDigitUsed);
        }

        private string ReturnCharacterIfDesiredIndexIs1(BigInteger desiredIndex, List<char> orderedCharacters)
        {
            if (desiredIndex != 1)
            {
                throw new ArgumentOutOfRangeException("The list of characters has length 1, while the desired index was not equal to 1.");
            }
            return orderedCharacters.Single().ToString();
        }
    }
}