﻿using Data.Computers;
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
                _ => 0,
            };
        }
    }
}
