using Microsoft.AspNetCore.Mvc;
using SMTRPZ_3.Dto;
using SMTRPZ_3.Service;
using System;

namespace SMTRPZ_3.Controller
{
    [ApiController]
    [Route("/api/trainer")]
    public class TrainerController
    {
        private readonly ITrainerService _trainerService;

        public TrainerController(ITrainerService trainerService)
        {
            _trainerService = trainerService;
        }

        [HttpPost(), Route("/new")]
        public IActionResult CreateTrainer([FromBody] TrainerDto trainerDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost(), Route("/remove")]
        public IActionResult RemoveTrainer([FromQuery] int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost(), Route("/update")]
        public IActionResult UpdateTrainer([FromBody] TrainerDto trainerDto)
        {
            throw new NotImplementedException();
        }

        [HttpGet(), Route("/{id}")]
        public IActionResult GetTrainer([FromRoute] int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet(), Route("/all")]
        public IActionResult GetAllTrainers()
        {
            throw new NotImplementedException();
        }
    }
}
