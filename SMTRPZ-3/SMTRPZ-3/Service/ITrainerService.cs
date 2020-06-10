using SMTRPZ_3.Dto;
using System.Collections.Generic;

namespace SMTRPZ_3.Service
{
    public interface ITrainerService
    {
        TrainerDto CreateTrainer(TrainerDto trainerDto);
        TrainerDto RemoveTrainer(int id);
        TrainerDto UpdateTrainer(TrainerDto trainerDto);
        TrainerDto GetTrainer(int id);
        List<TrainerDto> GetAllTrainers();
    }
}
