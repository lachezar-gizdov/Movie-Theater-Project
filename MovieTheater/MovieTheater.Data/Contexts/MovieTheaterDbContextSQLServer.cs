using System.Data.Entity;
using MovieTheater.Data.Contracts;
using MovieTheater.Models;

namespace MovieTheater.Data.Contexts
{
    public class MovieTheaterDbContextSQLServer : DbContext, IMovieTheaterDbContext
    {
        public MovieTheaterDbContextSQLServer()
            : base("MovieTheaterSQLServer")
        {
        }

        public IDbSet<Theater> Theaters { get; set; }

        public IDbSet<City> Cities { get; set; }

        public IDbSet<User> Users { get; set; }

        public IDbSet<Movie> Movies { get; set; }

        public IDbSet<Ticket> Tickets { get; set; }

        public IDbSet<Hall> Halls { get; set; }

        public IDbSet<HallSchedule> HallShedules { get; set; }        
    }
}