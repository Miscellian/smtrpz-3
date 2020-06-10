using SMTRPZ_3.Dto;
using SMTRPZ_3.Repository;
using System;
using System.Collections.Generic;

namespace SMTRPZ_3.Service.Impl
{
    public class TrainerService : ITrainerService
    {
        private readonly IUnitOfWork _dbUnit;

        public TrainerService(IUnitOfWork unitOfWork)
        {
            _dbUnit = unitOfWork;
        }

        public TrainerDto CreateTrainer(TrainerDto trainerDto)
        {
            throw new NotImplementedException();
        }

        public List<TrainerDto> GetAllTrainers()
        {
            throw new NotImplementedException();
        }

        public TrainerDto GetTrainer(int id)
        {
            throw new NotImplementedException();
        }

        public TrainerDto RemoveTrainer(int id)
        {
            throw new NotImplementedException();
        }

        public TrainerDto UpdateTrainer(TrainerDto trainerDto)
        {
            throw new NotImplementedException();
        }
    }
}
