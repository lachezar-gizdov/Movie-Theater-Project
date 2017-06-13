using System;
using System.Collections.Generic;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Models.Factory.Contracts;
using MovieTheater.Framework.Core.Commands.Contracts;
using System.Linq;

namespace MovieTheater.Framework.Core.Commands
{
    public class DeleteUserCommand : Command, ICommand
    {
        public DeleteUserCommand(IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory) : base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {
            if (parameters.Any(x => x == string.Empty))
            {
                throw new Exception("Some of the passed parameters are empty!");
            }

            var userId = Int32.Parse(parameters[0]);          
            var user = this.DbContext.Users.FirstOrDefault(c => c.Id == userId);

            if (user == null)
            {
                throw new ArgumentException("This user does not exist!");
            }

            this.DbContext.Users.Remove(user);
            this.DbContext.SaveChanges();

            return $"Successfully remove User with ID {user.Id}!";
        }
    }
}