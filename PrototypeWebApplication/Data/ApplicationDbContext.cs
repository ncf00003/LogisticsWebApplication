using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PrototypeWebApplication.Data.Tracking> Tracking { get; set; } = default!;
        //public DbSet<PrototypeWebApplication.Data.Shipment> Shipment { get; set; } = default!;
    }
}
