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

            while (currentIndex + FactorialHelper.Factorial(numberOfCharacters - 1) < desiredIndex)
            {
                currentIndex += FactorialHelper.Factorial(numberOfCharacters - 1);
                count += 1;
            }

            var characterToUse = orderedCharacters[count];
            var orderedDigitsWithoutDigitUsed = orderedCharacters.Where(character => character != characterToUse).ToList();

            return characterToUse.ToString() + GetNthLexiographicPermutation(desiredIndex - currentIndex, orderedDigitsWithoutDigitUsed);
        }

        public static List<string> ListOfNumbersWithIncreasingDigits(int numberOfDigits, List<char> orderedCharacters)
        {
            var listOfNumbersWithIncreasingDigits = new List<string>();

            if (numberOfDigits == 1)
            {
                return orderedCharacters.Select(character => character.ToString()).ToList();
            }

            foreach (char currentCharacter in orderedCharacters)
            {
                var characterAllowedToStillUse = orderedCharacters.Where(character => char.GetNumericValue(character) >= char.GetNumericValue(currentCharacter)).ToList();
                var currentList = ListOfNumbersWithIncreasingDigits(numberOfDigits - 1, characterAllowedToStillUse);

                foreach (string number in currentList)
                {
                    listOfNumbersWithIncreasingDigits.Add(currentCharacter.ToString() + number);
                }
            }

            return listOfNumbersWithIncreasingDigits;
        }

        public static BigInteger NumberOfPermutations(string number)
        {
            var numberOfPermutations = FactorialHelper.Factorial(number.Length);
            var distinctCharacters = number.Distinct();
            
            foreach (char distinctCharacter in distinctCharacters)
            {
                var numberOfTimesInNumber = number.Where(character => character == distinctCharacter).Count();
                numberOfPermutations /= FactorialHelper.Factorial(numberOfTimesInNumber);
            }

            return numberOfPermutations;
        }
    }
}
