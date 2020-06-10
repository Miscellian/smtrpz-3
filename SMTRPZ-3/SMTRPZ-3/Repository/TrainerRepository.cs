using SMTRPZ_3.Model;
using System.Collections.Generic;

namespace SMTRPZ_3.Repository
{
    public class TrainerRepository : IRepository<Trainer>
    {
        private readonly BuildTeamContext _dbContext;

        public TrainerRepository(BuildTeamContext buildTeamContext)
        {
            _dbContext = buildTeamContext;
        }

        public Trainer Create(Trainer entity)
        {
            throw new System.NotImplementedException();
        }

        public Trainer Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Trainer> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Trainer Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Trainer Update(Trainer entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
