using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace ffff.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TripContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TripContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
