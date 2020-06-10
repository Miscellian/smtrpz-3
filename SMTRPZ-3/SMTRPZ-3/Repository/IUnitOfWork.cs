namespace SMTRPZ_3.Repository
{
    public interface IUnitOfWork
    {
        public void Save();
        public void Dispose();
    }
}
