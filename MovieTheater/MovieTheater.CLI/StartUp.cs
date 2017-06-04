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

            var theater = new Theater() { Seats = 10};

            data.Theaters.Add(theater);
            data.SaveChanges();
        }
    }
}