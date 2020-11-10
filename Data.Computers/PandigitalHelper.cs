using System.Collections.Generic;
using System.Linq;

namespace Data.Computers
{
    public static class PandigitalHelper
    {
        public static List<string> GetPandigitalNumbers(List<char> characterAllowedTouse)
        {
            var pandigitalNumbers = new List<string>();

            if (characterAllowedTouse.Count == 1)
            {
                return new List<string> { characterAllowedTouse.Single().ToString() };
            }

            foreach (char currentCharacter in characterAllowedTouse)
            {
                var characterAllowedToUseWithoutCurrentCharachter = characterAllowedTouse.Where(characcter => characcter != currentCharacter).ToList();
                pandigitalNumbers.AddRange(GetPandigitalNumbers(characterAllowedToUseWithoutCurrentCharachter).Select(stringWithoutCurrentChar => currentCharacter.ToString() + stringWithoutCurrentChar));
            }

            return pandigitalNumbers;
        }

        // The number of digits of the multiplicant, multiplier and product together must sum to 9.
        // Let N(d) be the number of digits of d.
        // Then N(multiplicant) + N(multiplier) + N(product) = 9.
        // Moreover, N(multiplicant) + N(multiplier) <= N(product).
        // Hence N(product) must be at least 5, but it also cannot be more than 5.
        // Thus there are only 2 cases to check (modulo commutativity).
        // Case 1: N(multiplicant) = 1 and N(multiplier) = 4.
        // Case 2: N(multiplicant) = 2 and N(multiplier) = 3.
        public static List<long> GetListOfPandigitalProductForWhichMultiplicantMultiplierProductIdenitityConsistsOf9Digits()
        {
            var listOfPandigitalProducts = new List<long>();

            for (int multiplicant = 2; multiplicant <= 9; multiplicant++)
            {
                for (int multiplier = 1234; multiplier <= 9876; multiplier++)
                {
                    var product = multiplicant * multiplier;

                    if (Is1To9Pandigital(multiplicant.ToString() + multiplier.ToString() + product.ToString()))
                    {
                        listOfPandigitalProducts.Add(product);
                    }
                }
            }

            for (int multiplicant = 12; multiplicant <= 98; multiplicant++)
            {
                for (int multiplier = 123; multiplier <= 987; multiplier++)
                {
                    var product = multiplicant * multiplier;

                    if (Is1To9Pandigital(multiplicant.ToString() + multiplier.ToString() + product.ToString()))
                    {
                        listOfPandigitalProducts.Add(product);
                    }
                }
            }

            return listOfPandigitalProducts.Distinct().ToList();
        }

        public static string ConcatenatedProduct(int integer, List<int> numbersToMultiplyWith)
        {
            string concatenatedProduct = string.Empty;

            foreach (int numberToMultiplyWith in numbersToMultiplyWith)
            {
                concatenatedProduct += (integer * numberToMultiplyWith).ToString();
            }

            return concatenatedProduct;
        }

        public static bool Is1To9Pandigital(string number)
        {
            var requiredDigits = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            if (number.Length != 9)
            {
                return false;
            }

            foreach (char digit in requiredDigits)
            {
                if (!number.Contains(digit))
                {
                    return false;
                }
            }

            return true;
        }

        public static long GetLargest1To9PandigitalConcatenatedProduct()
        {
            long largestPandigitalFound = 0;

            for (int n = 2; n <= 9; n++)
            {
                int integer = 1;
                var numbersToMultiplyWith = Enumerable.Range(1, n).ToList();
                var concatenatedProduct = ConcatenatedProduct(integer, numbersToMultiplyWith);

                while (concatenatedProduct.Length <= 9)
                {
                    var concatenatedProductAsLong = long.Parse(concatenatedProduct);

                    if (Is1To9Pandigital(concatenatedProduct) && concatenatedProductAsLong > largestPandigitalFound)
                    {
                        largestPandigitalFound = concatenatedProductAsLong;
                    }

                    integer++;
                    concatenatedProduct = ConcatenatedProduct(integer, numbersToMultiplyWith);
                }
            }

            return largestPandigitalFound;
        }

        public static long GetLargestNPandigitalPrime()
        {
            // The sum of the digits of a pandigtal number with 8 or 9 digits is divisble by 9.
            // Hence the number itself will be divisble by 9 (divisibility condition), so it will not be prime.
            var characterAllowedTouse = new List<char> { '1', '2', '3', '4', '5', '6', '7' };
            var listOf1ToNPandigitalPrimes = GetPandigitalPrimes(characterAllowedTouse);

            while (listOf1ToNPandigitalPrimes.Count == 0)
            {
                characterAllowedTouse.RemoveAt(characterAllowedTouse.FindLastIndex(character => true));
                listOf1ToNPandigitalPrimes = GetPandigitalPrimes(characterAllowedTouse);
            }

            return listOf1ToNPandigitalPrimes.Max();
        }

        private static List<long> GetPandigitalPrimes(List<char> characterAllowedTouse)
        {
            return GetPandigitalNumbers(characterAllowedTouse)
                .Select(number => long.Parse(number)).Where(number => PrimeHelper.IsPrime(number)).ToList();
        }

        // d2d3d4 divisible by 2 => d4 ∈ {0, 2, 4, 6, 8}.
        // d4d5d6 divisble by 5 => d6 ∈ {0, 5}.
        // d6d7d8 divible by 11 + none of 0XX are allowed => d6 = 5.
        // Hence we leave out 5 (d6) when generating all the pandigtal numbers.
        // d8d9d10 must be divisble by 17, so we loop through all these possibilities first,
        // and use the left over characters for the remaining digits.
        public static List<long> Get0To9PandigitalNumbersWhichSatisfySubstringDivisibility()
        {
            var listOfPandigitalNumbersThatSatisfyCondition = new List<long>();
            var characterAllowedToUse = new List<char> { '0', '1', '2', '3', '4', '6', '7', '8', '9' };
            var characterAllowedForFourthDigit = new List<char> { '0', '2', '4', '6', '8' };

            var listOfPandigitalNumbers = new List<string>();

            foreach (char fourthDigit in characterAllowedForFourthDigit)
            {
                for (int lastThreeDigits = 17; lastThreeDigits < 1000; lastThreeDigits += 17)
                {
                    string lastThreeDigitsString;

                    if (lastThreeDigits < 100)
                    {
                        lastThreeDigitsString = '0'.ToString() + lastThreeDigits.ToString();
                    }
                    else
                    {
                        lastThreeDigitsString = lastThreeDigits.ToString();
                    }

                    if (!lastThreeDigitsString.Contains(fourthDigit) && lastThreeDigitsString.Distinct().Count() == lastThreeDigitsString.Length)
                    {
                        var currentCharsToUse = characterAllowedToUse.Where(character => character != fourthDigit && !lastThreeDigitsString.Contains(character)).ToList();
                        listOfPandigitalNumbers.AddRange(GetPandigitalNumbers(currentCharsToUse)
                        .Select(number => number.Substring(0, 3) + fourthDigit.ToString() + number.Substring(3, 1) + "5" + number.Substring(4, 1) + lastThreeDigitsString)
                        .Where(number => int.Parse(number.Substring(6, 3)) % 13 == 0
                        && int.Parse(number.Substring(5, 3)) % 11 == 0
                        && int.Parse(number.Substring(4, 3)) % 7 == 0
                        && int.Parse(number.Substring(2, 3)) % 3 == 0
                        && int.Parse(number.Substring(1, 3)) % 2 == 0));
                    }
                }
            }

            return listOfPandigitalNumbers.Select(number => long.Parse(number)).ToList();
        }
    }
}
