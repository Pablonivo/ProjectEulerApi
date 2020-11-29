namespace Data.Computers.Solutions
{
    public class Problem0007 : IProblem
    {
        private readonly int NUMBER = 10001;

        public long ComputeSolution()
        {
            return PrimeHelper.GetNthPrime(NUMBER);
        }
    }
}