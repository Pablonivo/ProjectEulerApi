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
    }
}
