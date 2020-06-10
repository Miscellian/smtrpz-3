using Microsoft.AspNetCore.Mvc;
using SMTRPZ_3.Dto;
using SMTRPZ_3.Service;
using System;

namespace SMTRPZ_3.Controller
{
    [ApiController]
    [Route("/api/team")]
    public class TeamController
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpPost(), Route("/new")]
        public IActionResult CreateTeam([FromBody] TeamDto teamDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost(), Route("/remove")]
        public IActionResult RemoveTeam([FromQuery] int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost(), Route("/update")]
        public IActionResult UpdateTeam([FromBody] TeamDto teamDto)
        {
            throw new NotImplementedException();
        }

        [HttpGet(), Route("/{id}")]
        public IActionResult GetTeam([FromRoute] int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet(), Route("/all")]
        public IActionResult GetAllTeams()
        {
            throw new NotImplementedException();
        }
    }
}
