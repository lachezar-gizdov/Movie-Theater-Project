using System;
using System.Collections.Generic;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;
using System.Linq;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateHallCommand : Command, ICommand
    {
        public CreateHallCommand(IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory) :
            base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {
            if (parameters.Any(x => x == string.Empty))
            {
                throw new Exception("Some of the passed parameters are empty!");
            }

            var hallName = parameters[0];
            var theater = this.DbContext.Theaters.FirstOrDefault(t => t.Name == hallName);

            if (theater == null)
            {
                throw new ArgumentException("This Theater does not exist!");
            }

            var hall = this.DbContext.Halls.FirstOrDefault(h => h.Name == hallName);

            if (hall != null)
            {
                throw new ArgumentException("This hall exist!");
            }

            var newHall = this.ModelsFactory.CreateHall(hallName, theater);
            this.DbContext.Halls.Add(newHall);
            this.DbContext.SaveChanges();

            return $"Successfully created a new User with ID {hall.Id}!";
        }
    }
}