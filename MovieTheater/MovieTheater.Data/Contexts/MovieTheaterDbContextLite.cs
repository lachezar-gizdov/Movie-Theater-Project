using MovieTheater.Data.Migrations;
using MovieTheater.Models;
using System.Data.Entity;

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
