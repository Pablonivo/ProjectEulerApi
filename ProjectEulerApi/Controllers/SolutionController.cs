using Data.Computers;
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
                1 => SolutionComputer.GetSolutionOfProblem1(),
                2 => SolutionComputer.GetSolutionOfProblem2(),
                3 => SolutionComputer.GetSolutionOfProblem3(),
                4 => SolutionComputer.GetSolutionOfProblem4(),
                5 => SolutionComputer.GetSolutionOfProblem5(),
                6 => SolutionComputer.GetSolutionOfProblem6(),
                7 => SolutionComputer.GetSolutionOfProblem7(),
                8 => SolutionComputer.GetSolutionOfProblem8(),
                9 => SolutionComputer.GetSolutionOfProblem9(),
                10 => SolutionComputer.GetSolutionOfProblem10(),
                11 => SolutionComputer.GetSolutionOfProblem11(),
                12 => SolutionComputer.GetSolutionOfProblem12(),
                13 => SolutionComputer.GetSolutionOfProblem13(),
                14 => SolutionComputer.GetSolutionOfProblem14(),
                15 => SolutionComputer.GetSolutionOfProblem15(),
                16 => SolutionComputer.GetSolutionOfProblem16(),
                17 => SolutionComputer.GetSolutionOfProblem17(),
                18 => SolutionComputer.GetSolutionOfProblem18(),
                19 => SolutionComputer.GetSolutionOfProblem19(),
                20 => SolutionComputer.GetSolutionOfProblem20(),
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
                56 => SolutionComputer.GetSolutionOfProblem56(),
                67 => SolutionComputer.GetSolutionOfProblem67(),
                _ => 0,
            };
        }
    }
}
