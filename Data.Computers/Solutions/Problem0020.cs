namespace Data.Computers.Solutions
{
    public class Problem0020 : IProblem
    {
        private readonly int NUMBER_TO_COMPUTE_FACTORIAL_OF = 100;

        public long ComputeSolution()
        {
            var factorial = FactorialHelper.Factorial(NUMBER_TO_COMPUTE_FACTORIAL_OF);
            return NumberHelper.SumOfDigits(factorial);
        }
    }
}