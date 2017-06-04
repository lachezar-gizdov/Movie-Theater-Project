using MovieTheater.Data;
using MovieTheater.Data.Migrations;
using MovieTheater.Models;
using System.Data.Entity;

namespace MovieTheater.CLI
{
    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieTheaterDbContext, Configuration>());
            var data = new MovieTheaterDbContext();
            var theater = new Theater() { Name = "Kino" };
            var movie = new Movie() { Name = "Movie Name", Year = 2017, Theater = theater };

            data.Theaters.Add(theater);
            data.Movies.Add(movie);

            data.SaveChanges();
        }
    }
}