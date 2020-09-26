using Data.Computers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjectEulerApi.Controllers
{
    [Route("api/solution")]
    [ApiController]
    public class SolutionController : ControllerBase
    {
        private readonly ISolutionComputer _solutionComputer;

        public SolutionController(ISolutionComputer solutioncomputer)
        {
            _solutionComputer = solutioncomputer;
        }

        [HttpGet]
        public long GetSolutionById(int solutionId)
        {
            return solutionId switch
            {
                1 => _solutionComputer.GetSolutionOfProblem1(),
                _ => 0,
            };
        }
    }
}
