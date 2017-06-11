using MovieTheater.Data.Contexts;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace MovieTheater.Data.Migrations
{
    public sealed class ConfigurationLite : DbMigrationsConfiguration<MovieTheaterDbContextLite>
    {
        public ConfigurationLite()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations";
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(MovieTheaterDbContextLite context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
