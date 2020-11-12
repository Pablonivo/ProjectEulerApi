using System;
using System.Numerics;

namespace Data.Computers
{
    public static class ModuloHelper
    {
        public static BigInteger ComputeAToThePowerBModuloC(BigInteger a, long b, long c)
        {
            var bInBaseTwo = Convert.ToString(b, 2);
            BigInteger result = 1;

            for (int i = bInBaseTwo.Length - 1; i >= 0; i--)
            {
                if (bInBaseTwo[i] == '1')
                {
                    result *= a;
                    result %= c;
                }

                a *= a;
                a %= c;
            }

            return result;
        }
    }
}
