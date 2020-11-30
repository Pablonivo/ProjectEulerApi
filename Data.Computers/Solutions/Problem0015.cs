namespace Data.Computers.Solutions
{
    public class Problem0015 : IProblem
    {
        private readonly int TOTAL_NUMBER_OF_STEPS = 40;
        private readonly int TOTAL_NUMBER_OF_STEPS_DOWNWARDS = 20;

        public long ComputeSolution()
        {
            return (long)FactorialHelper.BinominalCoefficient(TOTAL_NUMBER_OF_STEPS, TOTAL_NUMBER_OF_STEPS_DOWNWARDS);
        }
    }
}