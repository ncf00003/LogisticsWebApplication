// Natalia Furmanek Context Class

using LogisticsWebAppAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace LogisticsWebAppAPI.Data
{
    public class NFDbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;
        public NFDbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        // Mapping this object to the database table
        public DbSet<Tracking> Tracking {get; set;}
        // Starting with Tracking Info First
    }
}
