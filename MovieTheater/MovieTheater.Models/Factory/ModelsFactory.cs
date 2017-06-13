using MovieTheater.Models.Factory.Contracts;
using System.Collections.Generic;

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
                HallNumber = number,
                Theater = theater,
            };

            return hall;
        }

        public HallSchedule CreateHallSchedule(string number, Hall hall)
        {
            HallSchedule hallSchedule = new HallSchedule()
            {
                Number = number,
                Hall = hall
            };

            return hallSchedule;
        }

        public Ticket CreateTicket(int id, Movie movie, HallSchedule hallSchedule, decimal price, User user, int seat)
        {
            Ticket ticket = new Ticket()
            {
                Id = id,
                Movie = movie,
                HallSchedule = hallSchedule,
                Price = price,
                User = user,
                Seat = seat
            };

            return ticket;
        }

        public User CreateUser(string firstName, string lastName, City city)
        {
            User user = new User() { FirstName = firstName, LastName = lastName, City = city };
            return user;
        }

        public FoodShop CreateShop(string name)
        {
            var shop = new FoodShop { Name = name };
            return shop;
        }

        public StaffMember CreateStaffMember(string firstName, string LastName, Department department)
        {
            var staffMember = new StaffMember { FirstName = firstName, LastName = LastName, Department = department };
            return staffMember;
        }
    }
}