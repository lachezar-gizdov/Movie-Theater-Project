using System.Data.Entity;
using MovieTheater.Models;

namespace MovieTheater.Data
{
    public class MovieTheaterDbContext : DbContext
    {
        public MovieTheaterDbContext()
            : base("MovieTheater")
        {
        }

        public IDbSet<Theater> Theaters { get; set; }

        public IDbSet<City> Cities { get; set; }

        public IDbSet<User> Users { get; set; }

        public IDbSet<Movie> Movies { get; set; }

        public IDbSet<Ticket> Tickets { get; set; }

        public IDbSet<Hall> Halls { get; set; }

        public IDbSet<HallShedules> HallShedules { get; set; }
    }
}