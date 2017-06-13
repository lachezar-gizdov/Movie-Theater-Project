using System.Collections.Generic;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Core.Commands.Common
{
    public class DisplayIntroTextCommand : MovieTheaterCommand, ICommand
    {
        public DisplayIntroTextCommand(IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory) : 
            base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {
            return "Welcome to the Movie Theater Project! Type \"help\" to see a list of available commands.";
        }
    }
}
