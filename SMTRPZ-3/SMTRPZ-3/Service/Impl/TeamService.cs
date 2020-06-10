using SMTRPZ_3.Dto;
using SMTRPZ_3.Repository;
using System.Collections.Generic;

namespace SMTRPZ_3.Service.Impl
{
    public class TeamService : ITeamService
    {
        private readonly IUnitOfWork _dbUnit;

        public TeamService(IUnitOfWork unitOfWork)
        {
            _dbUnit = unitOfWork;
        }

        public TeamDto CreateTeam(TeamDto TeamDto)
        {
            throw new System.NotImplementedException();
        }

        public List<TeamDto> GetAllTeams()
        {
            throw new System.NotImplementedException();
        }

        public TeamDto GetTeam(int id)
        {
            throw new System.NotImplementedException();
        }

        public TeamDto RemoveTeam(int id)
        {
            throw new System.NotImplementedException();
        }

        public TeamDto UpdateTeam(TeamDto TeamDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
