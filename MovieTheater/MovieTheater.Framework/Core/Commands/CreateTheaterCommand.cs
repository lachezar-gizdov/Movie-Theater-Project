using System.Collections.Generic;
using MovieTheater.Data;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Framework.Models;
using System;
using System.Linq;

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

            var theater = this.factory.CreateTheater(parameters[0]);
            // this.dbContext.Theaters.Add(theater); //FIX ME

            return "Successfully created a new Theater!";
        }
    }
}
