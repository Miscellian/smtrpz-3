using System.Collections.Generic;

namespace SMTRPZ_3.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public TEntity Create(TEntity entity);
        public TEntity Remove(int id);
        public TEntity Update(TEntity entity);
        public TEntity Get(int id);
        public List<TEntity> GetAll();
    }
}
