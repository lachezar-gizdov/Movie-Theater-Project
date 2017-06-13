using System.Collections.Generic;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Models.Factory
{
    public class ModelsFactory : IModelsFactory
    {
        public Theater CreateTheater(string theaterName, City city)
        {
            Theater theater = new Theater() { Name = theaterName, City = city };

            return theater;
        }

        public Theater CreateTheater(string theaterName, City city, ICollection<User> users)
        {
            Theater theater = new Theater() { Name = theaterName, City = city, Users = users };

            return theater;
        }

        public City CreateCity(string cityName)
        {
            City city = new City() { Name = cityName };

            return city;
        }

        public Movie CreateMovie(string movieTitile, short movieYear, short movieDuration, string movieDirector)
        {
            Movie movie = new Movie()
            {
                Title = movieTitile,
                Year = movieYear,
                Duration = movieDuration,
                Director = movieDirector
            };

            return movie;
        }

        public Hall CreateHall(string number, Theater theater)
        {
            Hall hall = new Hall()
            {
                Number = number,
                Theater = theater
            };

            return hall;
        }

        public Ticket CreateTicket()
        {
            Ticket ticket = new Ticket();

            return ticket;
        }

        public User CreateUser(string firstName, string lastName, City city)
        {
            User user = new User() { FirstName = firstName, LastName = lastName, City = city };

            return user;
        }
    }
}