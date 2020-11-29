using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0009 : IProblem
    {
        private readonly int SUM_OF_DESIRED_PYTHAGOREAN_TRIPLET = 1000;

        public long ComputeSolution()
        {
            var (a, b, c) = PythagoreanTripletHelper.GetPythagoreanTripletForWhichSumEquals(SUM_OF_DESIRED_PYTHAGOREAN_TRIPLET).Single();
            return a * b * c;
        }
    }
}