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

        public Movie CreateMovie()
        {
            Movie movie = new Movie();

            return movie;
        }

        public Hall CreateHall()
        {
            Hall hall = new Hall();

            return hall;
        }

        public Ticket CreateTicket()
        {
            Ticket ticket = new Ticket();

            return ticket;
        }

        public User CreateUser(string firstName, string lastName, City city, Theater theater)
        {
            User user = new User() { FirstName = firstName, LastName = lastName, City = city, Theater = theater };

            return user;
        }
    }
}