using DataSQLite.Models;
using DataSQLite.YourDbMigrations;
using System.Data.Entity;

namespace DataSQLite
{
    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SQLDbContext, AwesomeConfig>());
            var data = new SQLDbContext();

            var genre = new Genre() { Name = "Comedy" };
            var movie = new Movie() { Name = "Movie", Genre = genre };

            data.Movies.Add(movie);
            data.SaveChanges();
        }
    }
}
