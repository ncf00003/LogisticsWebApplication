// Luke Chittenden Context Class

using LogisticsWebAppAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace LogisticsWebAppAPI.Data
{
    public class LukeDbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;
        public LukeDbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        // Mapping objects to the database table for Service Reference

        // SP Shipment Type
        public DbSet<User> user { get; set; }

        public DbSet<Shipment> shipment { get; set; }

        // SP Add Vehicle
        public DbSet<Vehicle> vehicle { get; set; }
    }
}