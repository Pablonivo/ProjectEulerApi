using System.Collections.Generic;
using Data.Computers.Interfaces;

namespace Data.Computers
{
    public class SolutionComputer : ISolutionComputer
    {
        public int GetSolutionOfProblem1()
        {
            var listOfNaturalNumbers = new List<int>{ 3, 5 };
            var max = 1000;
            var sumOfNaturalNumbersBelowMax = 0;

            for (int i = 0; i < max; i++)
            {
                foreach (int naturalNumber in listOfNaturalNumbers)
                {
                    if (i % naturalNumber == 0)
                    {
                        sumOfNaturalNumbersBelowMax += i;
                        break;
                    }
                }
            }

            return sumOfNaturalNumbersBelowMax;
        }
    }
}
