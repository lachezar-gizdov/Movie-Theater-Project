﻿using MovieTheater.Data.Contracts;
using MovieTheater.Models;
using System.Data.Entity;

namespace MovieTheater.Data.Contexts
{
    public class MovieTheaterDbContext : DbContext, IMovieTheaterDbContext
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