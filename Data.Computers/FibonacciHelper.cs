using System.Collections.Generic;

namespace Data.Computers
{
    public static class FibonacciHelper
    {
        public static List<int> GetFibonacciListBelowMax(int max)
        {
            var fibonacciList = new List<int> { 1, 2 };
            
            while (fibonacciList[^1] + fibonacciList[^2] < max)
            {
                fibonacciList.Add(fibonacciList[^1] + fibonacciList[^2]);
            }

            return fibonacciList;
        }
    }
}
