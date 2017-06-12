using System.Data.Entity.Migrations;
using MovieTheater.Data.Contexts;

namespace MovieTheater.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<MovieTheaterDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MovieTheaterDbContext context)
        {
        }
    }
}
