namespace MovieTheater.Models.Factory.Contracts
{
    public interface IModelsFactory
    {
        Theater CreateTheater(string theaterName, City city);

        Movie CreateMovie();

        Hall CreateHall();

        Ticket CreateTicket();

        User CreateUser(string fName, string lName, City city, Theater theater);
    }
}