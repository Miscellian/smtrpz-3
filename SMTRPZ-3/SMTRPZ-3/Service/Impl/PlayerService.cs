using SMTRPZ_3.Dto;
using SMTRPZ_3.Repository;
using System.Collections.Generic;

namespace SMTRPZ_3.Service.Impl
{
    public class PlayerService : IPlayerService
    {
        private readonly IUnitOfWork _dbUnit;

        public PlayerService(IUnitOfWork unitOfWork)
        {
            _dbUnit = unitOfWork;
        }

        public PlayerDto CreatePlayer(PlayerDto PlayerDto)
        {
            throw new System.NotImplementedException();
        }

        public List<PlayerDto> GetAllPlayers()
        {
            throw new System.NotImplementedException();
        }

        public PlayerDto GetPlayer(int id)
        {
            throw new System.NotImplementedException();
        }

        public PlayerDto RemovePlayer(int id)
        {
            throw new System.NotImplementedException();
        }

        public PlayerDto UpdatePlayer(PlayerDto PlayerDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
