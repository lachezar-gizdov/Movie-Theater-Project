using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.Framework.Core.Commands.Common
{
    public class DisplayHelpCommand : Command, ICommand
    {
        public DisplayHelpCommand(IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory) : 
            base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {
            var output = new StringBuilder();

            output.AppendLine("Below is the full list of supported commands:");
            output.AppendLine(" - Type \"createtheater [theater name] [city name]\" to create a new theater.");
            output.AppendLine(" - Type \"createmovie [movie title] [movie year] [movie duration] [movie director]\" to create a new theater.");
            output.AppendLine(" - Type \"createuser [first name] [last name] [city]");
            output.AppendLine(" - Type \"exit\" to quit the program.");

            return output.ToString();
        }

    }
}
