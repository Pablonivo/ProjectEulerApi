using System.Collections.Generic;
using System.Linq;

namespace Data.Computers
{
    public class FractionHelper
    {
        public static List<(int, int)> GetListOfFractionsThatCanBeSimplifiedIncorrectly(int maxSizeOfFractionParts)
        {
            var listOfFractionsThatCanBeSimplifiedIncorrectly = new List<(int, int)>();

            for (int n = 11; n <= maxSizeOfFractionParts; n++)
            {
                for (int d = n + 1; d <= maxSizeOfFractionParts; d++)
                {
                    if (CanFractionBeSimplifiedIncorrectly(n, d))
                    {
                        listOfFractionsThatCanBeSimplifiedIncorrectly.Add((n, d));
                    } 
                }
            }

            return listOfFractionsThatCanBeSimplifiedIncorrectly;
        }

        // For example 49/98 = 4/8 "by cancelling the 9's".
        public static bool CanFractionBeSimplifiedIncorrectly(int numerator, int denominator)
        {
            if (numerator % 10 == 0 && denominator % 10 == 0)
            {
                return false;
            }

            var numeratorToString = numerator.ToString();
            var denominatorToString = denominator.ToString();

            var charactersNumbersHaveInCommon = numeratorToString.Where(character => denominatorToString.Contains(character)).ToList();

            if (charactersNumbersHaveInCommon.Count == 0)
            {
                return false;
            }

            foreach(char character in charactersNumbersHaveInCommon)
            {
                var numeratorWithoutCharacter = int.Parse(numeratorToString.Remove(numeratorToString.IndexOf(character), 1));
                var denominatorWithoutCharacter = int.Parse(denominatorToString.Remove(denominatorToString.IndexOf(character), 1));

                if (numerator * denominatorWithoutCharacter == denominator * numeratorWithoutCharacter)
                {
                    return true;
                }
            }

            return false;
        }

        public static (int, int) ToLowestTerms(int numerator, int denominator)
        {
            var primeFactorizationNumerator = PrimeHelper.GetPrimeFactors(numerator);
            var primeFactorizationDenominator = PrimeHelper.GetPrimeFactors(denominator);

            var commonPrimes = primeFactorizationNumerator.Where(prime => primeFactorizationDenominator.Remove(prime));
            
            foreach(int prime in commonPrimes)
            {
                numerator /= prime;
                denominator /= prime;
            }

            return (numerator, denominator);
        }
    }
}
