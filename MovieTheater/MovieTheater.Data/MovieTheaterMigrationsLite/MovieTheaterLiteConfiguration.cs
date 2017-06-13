namespace MovieTheater.Data.MovieTheaterMigrationsLite
{
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;

    internal sealed class MovieTheaterLiteConfiguration : DbMigrationsConfiguration<MovieTheater.Data.Contexts.MovieTheaterDbContextLite>
    {
        public MovieTheaterLiteConfiguration()
        {
            this.SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MovieTheaterMigrationsLite";
        }

        protected override void Seed(MovieTheater.Data.Contexts.MovieTheaterDbContextLite context)
        {
        }
    }
}
