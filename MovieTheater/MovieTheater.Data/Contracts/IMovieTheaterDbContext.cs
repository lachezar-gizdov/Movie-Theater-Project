using System.Data.Entity;
using MovieTheater.Models;

namespace MovieTheater.Data.Contracts
{
    public interface IMovieTheaterDbContext
    {
        IDbSet<Theater> Theaters { get; set; }

        IDbSet<City> Cities { get; set; }

        IDbSet<User> Users { get; set; }

        IDbSet<Movie> Movies { get; set; }

        IDbSet<Ticket> Tickets { get; set; }

        IDbSet<Hall> Halls { get; set; }

        IDbSet<HallSchedule> HallShedules { get; set; }

        IDbSet<Seat> Seat { get; set; }

        int SaveChanges();
    }
}
