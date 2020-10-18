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

        public static (bool, long) IsPandigitalProduct(string pandigitalNumber)
        {
            var lengthOfNumber = pandigitalNumber.Length;

            for (int i = 0; i <= lengthOfNumber - 3; i++)
            {
                for (int j = 0; i + j <= lengthOfNumber - 3; j++)
                {
                    var multiplicand = long.Parse(pandigitalNumber.Substring(0, i + 1));
                    var multiplier = long.Parse(pandigitalNumber.Substring(i + 1, j + 1));
                    var product = long.Parse(pandigitalNumber.Substring(i + j + 2, lengthOfNumber - i - j - 2));

                    if (multiplicand * multiplier == product)
                    {
                        return (true, product);
                    }
                }
            }

            return (false, 0);
        }

        public static List<long> GetListOfPandigitalProducts(List<char> characterAllowedTouse)
        {
            var listOfPandigitalProducts = new List<long>();
            var listOfPandigitalNumbers = GetPandigitalNumbers(characterAllowedTouse);

            listOfPandigitalNumbers.ForEach(pandigitalNumber =>
            {
                (bool isPandigitalProduct, long product) = IsPandigitalProduct(pandigitalNumber);

                if (isPandigitalProduct)
                {
                    listOfPandigitalProducts.Add(product);
                }
            });

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
            var characterAllowedTouse = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
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
    }
}
