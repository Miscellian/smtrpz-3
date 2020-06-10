using SMTRPZ_3.Model;
using System;

namespace SMTRPZ_3.Repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly BuildTeamContext _dbContext;
        private IRepository<Player> _playerRepository;
        private IRepository<Team> _teamRepository;
        private IRepository<Trainer> _trainerRepository;

        public UnitOfWork(BuildTeamContext buildTeamContext)
        {
            _dbContext = buildTeamContext;
        }

        public IRepository<Player> Players
        {
            get
            {
                if (_playerRepository == null)
                    _playerRepository = new PlayerRepository(_dbContext);
                return _playerRepository;
            }
        }

        public IRepository<Team> Teams
        {
            get
            {
                if (_teamRepository == null)
                    _teamRepository = new TeamRepository(_dbContext);
                return _teamRepository;
            }
        }

        public IRepository<Trainer> Trainers
        {
            get
            {
                if (_trainerRepository == null)
                    _trainerRepository = new TrainerRepository(_dbContext);
                return _trainerRepository;
            }
        }


        public void Save()
        {
            _dbContext.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
