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
                67 => SolutionComputer.GetSolutionOfProblem67(),
                _ => 0,
            };
        }
    }
}
