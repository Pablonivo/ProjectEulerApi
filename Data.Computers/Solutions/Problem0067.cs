namespace Data.Computers.Solutions
{
    public class Problem0067 : IProblem
    {
        private readonly int[,] NUMBER_TRIANGLE = TestData.TestData.TriangleProblem67();

        public long ComputeSolution()
        {
            return new Problem0018(NUMBER_TRIANGLE).ComputeSolution();
        }
    }
}