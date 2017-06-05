using System.Collections.Generic;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Data;
using MovieTheater.Framework.Models;

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
            return "Successfully created a new Theater!";
        }
    }
}
