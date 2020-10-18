namespace Data.Computers
{
    public static class PythagoreanTripletHelper
    {
        public static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }

        public static (int, int, int) GetPythagoreanTripletForWhichSumEquals(int sum)
        {
            for (int a = 1; a < sum / 3; a++)
            {
                for (int b = a + 1; b < 2 * sum / 3; b++)
                {
                    int c = sum - a - b;

                    if (c > b && IsPythagoreanTriplet(a, b, c))
                    {
                        return (a, b, c);
                    }
                }
            }

            return (0, 0, 0);
        }
    }
}
