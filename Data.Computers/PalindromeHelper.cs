using System.Linq;

namespace Data.Computers
{
    public static class PalindromeHelper
    {
        public static bool IsPalindrome(int number)
        {
            var numberAsString = number.ToString();

            for (int i=0; i < numberAsString.Count()/2; i++)
            {
                if (numberAsString[i] != numberAsString[^(1 + i)])
                {
                    return false;
                }
            }

            return true;
        }

        public static int GetLargestPalindromeOfProductOfTwoNumbersBelowMax(int max)
        {
            var largestPalindromeProductFound = 0;

            for (int i = 1; i < max; i++) {
                for (int j = i; j < max; j++)
                {
                    var product = i * j;
                    if (IsPalindrome(product) && product > largestPalindromeProductFound)
                    {
                        largestPalindromeProductFound = product;
                    }
                }
            }

            return largestPalindromeProductFound;
        }
    }
}
