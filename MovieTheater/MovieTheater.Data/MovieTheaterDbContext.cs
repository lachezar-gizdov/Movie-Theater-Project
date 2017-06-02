using MovieTheater.Models;
using System.Data.Entity;

namespace MovieTheater.Data
{
    public class MovieTheaterDbContext : DbContext
    {
        public MovieTheaterDbContext()
            : base("MovieTheater")
        {
        }

        public IDbSet<Theater> Theaters { get; set; }
    }
}