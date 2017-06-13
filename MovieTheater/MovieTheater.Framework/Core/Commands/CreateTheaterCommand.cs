using System;
using System.Collections.Generic;
using System.Linq;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateTheaterCommand : MovieTheaterCommand, ICommand
    {
        public CreateTheaterCommand(IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory) : 
            base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {
            if (parameters.Any(x => x == string.Empty))
            {
                throw new ArgumentException("Some of the passed parameters are empty!");
            }

            var cityName = parameters[1];
            var city = this.DbContext.Cities.FirstOrDefault(c => c.Name == cityName);
           
            if (city == null)
            {
                city = this.ModelsFactory.CreateCity(cityName);
            }

            var theater = this.ModelsFactory.CreateTheater(parameters[0], city);

            this.DbContext.Theaters.Add(theater);
            this.DbContext.SaveChanges();

            return $"Successfully created a new Theater with ID {theater.Id}!";
        }
    }
}