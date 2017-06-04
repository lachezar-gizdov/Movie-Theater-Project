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

            var theater = new Theater() { Name = "test"};

            data.Theaters.Add(theater);
            data.SaveChanges();
        }
    }
}