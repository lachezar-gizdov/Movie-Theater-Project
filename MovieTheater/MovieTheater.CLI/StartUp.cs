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
            var theater = new Theater() { TheaterName = "Kino" };
            var movie = new Movie() { Name = "Movie Name", Year = 2017, Theater = theater };
            var user = new User() {FirstName = "fname", LastName = "lname", Theater = theater};

            data.Theaters.Add(theater);
            data.Users.Add(user);
            data.Movies.Add(movie);

            data.SaveChanges();
        }
    }
}