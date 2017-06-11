using System;
using System.Collections.Generic;
using System.Linq;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateUserCommand : Command, ICommand
    {
        public CreateUserCommand(IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory) : 
            base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {
            if (parameters.Any(x => x == string.Empty))
            {
                throw new Exception("Some of the passed parameters are empty!");
            }

            var cityName = parameters[2];
            var theaterName = parameters[3];
            var city = this.DbContext.Cities.FirstOrDefault(c => c.Name == cityName);

            if (city == null)
            {
                city = this.ModelsFactory.CreateCity(cityName);
            }

            var theater = this.DbContext.Theaters.FirstOrDefault(t => t.Name == theaterName);

            var user = this.ModelsFactory.CreateUser(parameters[0], parameters[1], city);
            this.DbContext.Users.Add(user);
            this.DbContext.SaveChanges();

            return $"Successfully created a new User with ID {user.Id}!";
        }
    }
}