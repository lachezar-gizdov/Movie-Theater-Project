namespace MovieTheater.Models.Factory
{
    public class ModelsFactory
    {
        public Theater CreateTheater(string theaterName)
        {
            Theater theater = new Theater() { TheaterName = theaterName };

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

        public User CreateUser()
        {
            User user = new User();

            return user;
        }
    }
}
