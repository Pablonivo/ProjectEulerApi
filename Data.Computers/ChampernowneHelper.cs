using System;

namespace Data.Computers
{
    public static class ChampernowneHelper
    {
        // Number of integers with 1 digits: 1 to 9 (9), so 1 to 9 are 1 to 9
        // Number of integers with 2 digits: 10 to 99 (90), so 10 to 189 are 10 to 99.
        // Number of integers with 3 digits: 100 to 999 (900) etc etc..
        public static int GetNthDigitOfChampernownesConstant(int desiredDigit)
        {
            int index = 1;
            var numberOfDigitsInFrontUsed = 0;

            while (numberOfDigitsInFrontUsed + (int)(index * (Math.Pow(10, index) - Math.Pow(10, index - 1))) < desiredDigit)
            {
                numberOfDigitsInFrontUsed += (int)(index * (Math.Pow(10, index) - Math.Pow(10, index - 1)));
                index++;
            }

            var desiredDigitForAllNumbersWithIndexNumberOfDigits = desiredDigit - numberOfDigitsInFrontUsed - 1;
            var nthNumberWithIndexNumberOfDigitsWeAreLookingFor = desiredDigitForAllNumbersWithIndexNumberOfDigits / index;
            var desiredNumber = (int)(Math.Pow(10, index - 1) + nthNumberWithIndexNumberOfDigitsWeAreLookingFor);
            return (int)char.GetNumericValue(desiredNumber.ToString()[desiredDigitForAllNumbersWithIndexNumberOfDigits % index]);
        }
    }
}
