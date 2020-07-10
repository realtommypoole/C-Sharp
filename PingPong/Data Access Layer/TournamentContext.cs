using PingPong.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PingPong.Data_Access_Layer
{
    public class TournamentContext : DbContext
    {
        public TournamentContext() : base("TournamentContext")
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}