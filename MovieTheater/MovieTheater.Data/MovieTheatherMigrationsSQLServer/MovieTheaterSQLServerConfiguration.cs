namespace MovieTheater.Data.MovieTheatherMigrationsSQLServer
{
    using System.Data.Entity.Migrations;

    internal sealed class MovieTheaterSQLServerConfiguration : DbMigrationsConfiguration<MovieTheater.Data.Contexts.MovieTheaterDbContextSQLServer>
    {
        public MovieTheaterSQLServerConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MovieTheatherMigrationsSQLServer";
        }

        protected override void Seed(MovieTheater.Data.Contexts.MovieTheaterDbContextSQLServer context)
        {
        }
    }
}
