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
                _ => 0,
            };
        }
    }
}
