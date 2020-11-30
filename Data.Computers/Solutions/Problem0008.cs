namespace Data.Computers.Solutions
{
    public class Problem0008 : IProblem
    {
        private readonly int NUMBER_OF_ADJACENT_DIGITS = 13;
        private readonly string GRID_AS_STRING = TestData.TestData.Get1000digitNumberProblem8();

        public Problem0008(int numberOfAdjacentDigits)
        {
            NUMBER_OF_ADJACENT_DIGITS = numberOfAdjacentDigits;
        }

        public Problem0008()
        {

        }

        public long ComputeSolution()
        {
            return GetLargestProductOfAdjacentNumbersInString(GRID_AS_STRING, NUMBER_OF_ADJACENT_DIGITS);
        }

        private static long GetLargestProductOfAdjacentNumbersInString(string stringOfNumbers, int numberOfAdjacentDigits)
        {
            long largestProductFound = 0;
            for (int i = 0; i < stringOfNumbers.Length - numberOfAdjacentDigits; i++)
            {
                long currentProduct = 1;
                for (int j = i; j < i + numberOfAdjacentDigits; j++)
                {
                    currentProduct *= ToLongDigit(stringOfNumbers[j]);
                }
                if (currentProduct > largestProductFound)
                {
                    largestProductFound = currentProduct;
                }
            }
            return largestProductFound;
        }

        private static long ToLongDigit(char character)
        {
            return (long)char.GetNumericValue(character);
        }
    }
}