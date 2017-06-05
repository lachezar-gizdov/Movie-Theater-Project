using MovieTheater.Framework.Models.Contracts;

namespace MovieTheater.Framework.Models
{
    public class ModelsFactory : IModelsFactory
    {
        public ITheater CreateTheater()
        {
            ITheater theater = new Theater();

            return theater;
        }

        public IMovie CreateMovie()
        {
            IMovie movie = new Movie();

            return movie;
        }

        public IHall CreateHall()
        {
            IHall hall = new Hall();

            return hall;
        }

        public ITicket CreateTicket()
        {
            ITicket ticket = new Ticket();

            return ticket;
        }

        public IUser CreateUser()
        {
            IUser user = new User();

            return user;
        }
    }
}
