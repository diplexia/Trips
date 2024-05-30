using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace ffff
{
    class TripContext : DbContext
    {
        public TripContext() : base("DefaultConnection") { }
        public DbSet<Trip> Trips { get; set; }
    }
}
