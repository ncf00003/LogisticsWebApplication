// Leonardo Cuellar Context Class

using LogisticsWebAppAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace LogisticsWebAppAPI.Data
{
    public class LCDbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;
        public LCDbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        // Mapping objects to the database table for Service Reference

        // SP Delivery Tracking Tables
        public DbSet<Tracking> tracking { get; set; }

        // Need seperate context connections for each table used in stored procedures
        public DbSet<User> user { get; set; }

        public DbSet<Shipment> shipment { get; set; }


        // SP Vehicle Drivers SP
        public DbSet<Vehicle> vehicle { get; set; }
    }
}
