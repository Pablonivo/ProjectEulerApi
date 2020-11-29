using System;
using System.Numerics;

namespace Data.Computers
{
    public static class PalindromeHelper
    {
        public static bool IsPalindrome(BigInteger number)
        {
            return IsPalindrome(number.ToString());
        }

        public static bool IsPalindrome(string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[^(1 + i)])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPalindromeInBase2(int number)
        {
            var numberInbase2 = Convert.ToString(number, 2);
            return IsPalindrome(numberInbase2);
        }
    }
}
