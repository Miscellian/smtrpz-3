using Microsoft.AspNetCore.Mvc;
using SMTRPZ_3.Dto;
using SMTRPZ_3.Service;
using System;

namespace SMTRPZ_3.Controller
{
    [ApiController]
    [Route("/api/player")]
    public class PlayerController
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpPost(), Route("/new")]
        public IActionResult CreatePlayer([FromBody] PlayerDto playerDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost(), Route("/remove")]
        public IActionResult RemovePlayer([FromQuery] int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost(), Route("/update")]
        public IActionResult UpdatePlayer([FromBody] PlayerDto PlayerDto)
        {
            throw new NotImplementedException();
        }

        [HttpGet(), Route("/{id}")]
        public IActionResult GetPlayer([FromRoute] int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet(), Route("/all")]
        public IActionResult GetAllPlayers()
        {
            throw new NotImplementedException();
        }
    }
}
