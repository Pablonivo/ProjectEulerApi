using Data.Computers;
using Data.Computers.Solutions;
using Microsoft.AspNetCore.Mvc;

namespace ProjectEulerApi.Controllers
{
    [Route("api/solution")]
    [ApiController]
    public class SolutionController : ControllerBase
    {
        [HttpGet]
        public ActionResult<long> GetSolutionById(int solutionId)
        {
            return solutionId switch
            {
                1 => new Problem0001().ComputeSolution(),
                2 => new Problem0002().ComputeSolution(),
                3 => new Problem0003().ComputeSolution(),
                4 => new Problem0004().ComputeSolution(),
                5 => new Problem0005().ComputeSolution(),
                6 => new Problem0006().ComputeSolution(),
                7 => new Problem0007().ComputeSolution(),
                8 => new Problem0008().ComputeSolution(),
                9 => new Problem0009().ComputeSolution(),
                10 => new Problem0010().ComputeSolution(),
                11 => new Problem0011().ComputeSolution(),
                12 => new Problem0012().ComputeSolution(),
                13 => new Problem0013().ComputeSolution(),
                14 => new Problem0014().ComputeSolution(),
                15 => new Problem0015().ComputeSolution(),
                16 => new Problem0016().ComputeSolution(),
                17 => new Problem0017().ComputeSolution(),
                18 => new Problem0018().ComputeSolution(),
                19 => new Problem0019().ComputeSolution(),
                20 => new Problem0020().ComputeSolution(),
                21 => SolutionComputer.GetSolutionOfProblem21(),
                22 => SolutionComputer.GetSolutionOfProblem22(),
                23 => SolutionComputer.GetSolutionOfProblem23(),
                24 => SolutionComputer.GetSolutionOfProblem24(),
                25 => SolutionComputer.GetSolutionOfProblem25(),
                26 => SolutionComputer.GetSolutionOfProblem26(),
                27 => SolutionComputer.GetSolutionOfProblem27(),
                28 => SolutionComputer.GetSolutionOfProblem28(),
                29 => SolutionComputer.GetSolutionOfProblem29(),
                30 => SolutionComputer.GetSolutionOfProblem30(),
                31 => SolutionComputer.GetSolutionOfProblem31(),
                32 => SolutionComputer.GetSolutionOfProblem32(),
                33 => SolutionComputer.GetSolutionOfProblem33(),
                34 => SolutionComputer.GetSolutionOfProblem34(),
                35 => SolutionComputer.GetSolutionOfProblem35(),
                36 => SolutionComputer.GetSolutionOfProblem36(),
                37 => SolutionComputer.GetSolutionOfProblem37(),
                38 => SolutionComputer.GetSolutionOfProblem38(),
                39 => SolutionComputer.GetSolutionOfProblem39(),
                40 => SolutionComputer.GetSolutionOfProblem40(),
                41 => SolutionComputer.GetSolutionOfProblem41(),
                42 => SolutionComputer.GetSolutionOfProblem42(),
                43 => SolutionComputer.GetSolutionOfProblem43(),
                44 => SolutionComputer.GetSolutionOfProblem44(),
                45 => SolutionComputer.GetSolutionOfProblem45(),
                46 => SolutionComputer.GetSolutionOfProblem46(),
                47 => SolutionComputer.GetSolutionOfProblem47(),
                48 => SolutionComputer.GetSolutionOfProblem48(),
                49 => SolutionComputer.GetSolutionOfProblem49(),
                50 => SolutionComputer.GetSolutionOfProblem50(),
                51 => SolutionComputer.GetSolutionOfProblem51(),
                52 => SolutionComputer.GetSolutionOfProblem52(),
                53 => SolutionComputer.GetSolutionOfProblem53(),
                54 => SolutionComputer.GetSolutionOfProblem54(),
                55 => SolutionComputer.GetSolutionOfProblem55(),
                56 => SolutionComputer.GetSolutionOfProblem56(),
                57 => SolutionComputer.GetSolutionOfProblem57(),
                58 => SolutionComputer.GetSolutionOfProblem58(),
                59 => SolutionComputer.GetSolutionOfProblem59(),
                62 => SolutionComputer.GetSolutionOfProblem62(),
                63 => SolutionComputer.GetSolutionOfProblem63(),
                65 => SolutionComputer.GetSolutionOfProblem65(),
                67 => new Problem0067().ComputeSolution(),
                69 => SolutionComputer.GetSolutionOfProblem69(),
                79 => SolutionComputer.GetSolutionOfProblem79(),
                81 => SolutionComputer.GetSolutionOfProblem81(),
                92 => SolutionComputer.GetSolutionOfProblem92(),
                97 => SolutionComputer.GetSolutionOfProblem97(),
                _ => 0,
            };
        }
    }
}
