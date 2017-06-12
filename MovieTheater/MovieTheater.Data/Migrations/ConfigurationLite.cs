using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;
using MovieTheater.Data.Contexts;

namespace MovieTheater.Data.Migrations
{
    public sealed class ConfigurationLite : DbMigrationsConfiguration<MovieTheaterDbContextLite>
    {
        public ConfigurationLite()
        {
            this.AutomaticMigrationsEnabled = true;
            this.MigrationsDirectory = @"Migrations";
            this.SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(MovieTheaterDbContextLite context)
        {
        }
    }
}