namespace MovieTheater.Data.MovieTheatherMigrationsSQLServer
{
    using System.Data.Entity.Migrations;

    internal sealed class MovieTheaterSQLServerConfiguration : DbMigrationsConfiguration<Contexts.MovieTheaterDbContextSQLServer>
    {
        public MovieTheaterSQLServerConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MovieTheatherMigrationsSQLServer";
        }

        protected override void Seed(Contexts.MovieTheaterDbContextSQLServer context)
        {
        }
    }
}
