using System;

namespace Data.Computers
{
    public static class HexagonalNumberHelper
    {
        public static long GetNthHexagonalNumber(int n)
        {
            return n * (2 * n - 1);
        }
    }
}
