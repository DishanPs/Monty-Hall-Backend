using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MontyHallProblem.Models;
using MontyHallProblem.Services;

namespace MontyHallProblem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MontyHallController : ControllerBase
    {
        private readonly MontyHallService _montyHallService;

        // Initialize the controller with MontyHallService
        public MontyHallController()
        {
            _montyHallService = new MontyHallService();
        }

        [HttpGet("simulate")]
        public ActionResult<SimulationResult> Simulate(int numberOfGames, bool switchDoor)
        {
            var result = _montyHallService.RunSimulation(numberOfGames, switchDoor);
            return Ok(result);
        }
    }
}
