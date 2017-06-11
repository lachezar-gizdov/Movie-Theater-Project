using System.Collections.Generic;

namespace MovieTheater.Models.Factory.Contracts
{
    public interface IModelsFactory
    {
        Theater CreateTheater(string theaterName, City city);

        Theater CreateTheater(string theaterName, City city, ICollection<User> users);

        City CreateCity(string cityName);

        Movie CreateMovie();

        Hall CreateHall();

        Ticket CreateTicket();

        User CreateUser(string firstName, string lastName, City city);
    }
}