using System;
using System.Collections.Generic;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Data;
using MovieTheater.Models.Factory;
using System.Linq;
using MovieTheater.Models;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateUserCommand : ICommand
    {
        private MovieTheaterDbContext dbContext;
        private ModelsFactory factory;

        public CreateUserCommand(MovieTheaterDbContext dbContext, ModelsFactory factory)
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

            //var city = dbContext.Cities.Where(c => c.Name == parameters[2]).FirstOrDefault();

            //if (city == null)
            //{
            //    city = new City() { Name = parameters[2] };
            //}

            var city = new City() { Name = parameters[2] };
            var theater = new Theater() { Name = parameters[3], City = city };

            var user = this.factory.CreateUser(parameters[0], parameters[1], city, theater);
            this.dbContext.Users.Add(user);
            dbContext.SaveChanges();
            
            return "Successfully created a new User!";
        }
    }
}