using DataSQLite.Models;
using DataSQLite.YourDbMigrations;
using System.Data.Entity;

namespace DataSQLite
{
    public class SQLDbContext : DbContext
    {
        public SQLDbContext()
            : base("MovieTheater")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SQLDbContext, YourDbMigrations.AwesomeConfig>(true));
        }

        public IDbSet<Movie> Movies { get; set; }

        public IDbSet<Genre> Genres { get; set; }
    }
}
