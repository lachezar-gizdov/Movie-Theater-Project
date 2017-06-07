using System.Collections.Generic;
using MovieTheater.Data;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory;
using System;
using System.Linq;
using MovieTheater.Models;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateTheaterCommand : ICommand
    {
        private MovieTheaterDbContext dbContext;
        private ModelsFactory factory;

        public CreateTheaterCommand(MovieTheaterDbContext dbContext, ModelsFactory factory)
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

            var city = new City() { Name = parameters[1] };
            var theater = this.factory.CreateTheater(parameters[0], city);
            this.dbContext.Theaters.Add(theater);
            dbContext.SaveChanges();

            return "Successfully created a new Theater!";
        }
    }
}