using System;

namespace Data.Computers.Solutions
{
    public class Problem0004 : IProblem
    {
        private readonly int NUMBER_OF_DIGITS_MULTIPLICANDS_PALINDROME = 3;

        public Problem0004(int numberOfDigitsMultiplcandsPalindrome)
        {
            NUMBER_OF_DIGITS_MULTIPLICANDS_PALINDROME = numberOfDigitsMultiplcandsPalindrome;
        }

        public Problem0004()
        {

        }

        public long ComputeSolution()
        {
            var upperBound = GetUpperBoundMultiplicands(NUMBER_OF_DIGITS_MULTIPLICANDS_PALINDROME);
            return GetLargestPalindromeOfProductOfTwoNumbersBelowUpperBound(upperBound);
        }

        private static int GetUpperBoundMultiplicands(int numberOfDigits)
        {
            return (int)Math.Pow(10, numberOfDigits);
        }

        private static int GetLargestPalindromeOfProductOfTwoNumbersBelowUpperBound(int upperBound)
        {
            var largestPalindromeProductFound = 0;
            for (int i = 1; i < upperBound; i++)
            {
                for (int j = i; j < upperBound; j++)
                {
                    var product = i * j;
                    if (PalindromeHelper.IsPalindrome(product) && product > largestPalindromeProductFound)
                    {
                        largestPalindromeProductFound = product;
                    }
                }
            }
            return largestPalindromeProductFound;
        }
    }
}