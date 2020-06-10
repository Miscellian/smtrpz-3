using SMTRPZ_3.Model;
using System.Data.Entity;

namespace SMTRPZ_3.Repository
{
    public class BuildTeamContext: DbContext
    {
        public BuildTeamContext() : base("") { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
