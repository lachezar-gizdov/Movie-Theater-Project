using System;
using System.Collections.Generic;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Data;
using MovieTheater.Models.Factory;
using System.Linq;

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

            var user = this.factory.CreateUser(parameters[0], parameters[1]);
            this.dbContext.Users.Add(user);
            dbContext.SaveChanges();

            return "Successfully created a new User!";
        }
    }
}