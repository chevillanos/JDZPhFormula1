using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JDZPhFormula1.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Classification> Classifications { get; set; }
        public DbSet<GameSeason> GameSeasons { get; set; }
        public DbSet<RaceDetail> RaceDetails { get; set; }
        public DbSet<RaceSession> RaceSessions { get; set; }
        public DbSet<RaceResult> RaceResults { get; set; }



        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}