using System;
using System.Collections.Generic;
using System.Linq;
using MovieTheater.Data;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateUserCommand : ICommand
    {
        private MovieTheaterDbContext dbContext;
        private IModelsFactory factory;

        public CreateUserCommand(MovieTheaterDbContext dbContext, IModelsFactory factory)
        {
            this.dbContext = dbContext;
            this.factory = factory;
        }

        public string Execute(List<string> parameters)
        {
            if (parameters.Any(x => x == string.Empty))
            {
                throw new Exception("Some of the passed parameters are empty!");
            }


            var cityName = parameters[2];
            var theaterName = parameters[3];
            var city = dbContext.Cities.FirstOrDefault(c => c.Name == cityName);

            if (city == null)
            {
                city = this.factory.CreateCity(cityName);
            }

            var theater = dbContext.Theaters.FirstOrDefault(t => t.Name == theaterName);

            var user = this.factory.CreateUser(parameters[0], parameters[1], city, theater);
            this.dbContext.Users.Add(user);
            this.dbContext.SaveChanges();

            return $"Successfully created a new User with ID {user.Id}!";
        }
    }
}