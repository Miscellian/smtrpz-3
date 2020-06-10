using SMTRPZ_3.Model;
using System.Collections.Generic;

namespace SMTRPZ_3.Repository
{
    public class TeamRepository : IRepository<Team>
    {
        private readonly BuildTeamContext _dbContext;

        public TeamRepository(BuildTeamContext buildTeamContext)
        {
            _dbContext = buildTeamContext;
        }

        public Team Create(Team entity)
        {
            throw new System.NotImplementedException();
        }

        public Team Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Team> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Team Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Team Update(Team entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
