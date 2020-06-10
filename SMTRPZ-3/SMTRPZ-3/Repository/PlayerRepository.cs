using SMTRPZ_3.Model;
using System.Collections.Generic;

namespace SMTRPZ_3.Repository
{
    public class PlayerRepository : IRepository<Player>
    {
        private readonly BuildTeamContext _dbContext;

        public PlayerRepository(BuildTeamContext buildTeamContext)
        {
            _dbContext = buildTeamContext;
        }

        public Player Create(Player entity)
        {
            throw new System.NotImplementedException();
        }

        public Player Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Player> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Player Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Player Update(Player entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
