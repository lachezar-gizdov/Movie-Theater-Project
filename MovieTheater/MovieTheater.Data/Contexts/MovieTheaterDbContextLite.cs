using System.Data.Entity;
using MovieTheater.Data.Migrations;
using MovieTheater.Models;

namespace MovieTheater.Data.Contexts
{
    public class MovieTheaterDbContextLite : DbContext
    {
        public MovieTheaterDbContextLite()
            : base("MovieTheater")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieTheaterDbContextLite, ConfigurationLite>(true));
        }

        public IDbSet<FoodShop> FoodShops { get; set; }
    }
}
