using System.Collections.Generic;

namespace MovieTheater.Models.Factory.Contracts
{
    public interface IModelsFactory
    {
        Theater CreateTheater(string theaterName, City city);

        Theater CreateTheater(string theaterName, City city, ICollection<User> users);

        City CreateCity(string cityName);

        Movie CreateMovie(string movieTitle, short movieYear, short movieLength, string movieDirector);

        Hall CreateHall(string number,Theater Theater);

        HallSchedule CreateHallSchedule(string number, Hall hall);

        Ticket CreateTicket();

        User CreateUser(string firstName, string lastName, City city);
    }
}