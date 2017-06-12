using System;
using System.Collections.Generic;
using System.Linq;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateMovieCommand : Command, ICommand
    {
        public CreateMovieCommand(IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory) : 
            base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {
            if (parameters.Any(x => x == string.Empty))
            {
                throw new ArgumentException("Some of the passed parameters are empty!");
            }

            var movieTitle = parameters[0];
            var movieYear = short.Parse(parameters[1]);
            var movieDuration = short.Parse(parameters[2]);
            var movieDirector = parameters[3];

            var movie = this.ModelsFactory.CreateMovie(movieTitle, movieYear, movieDuration, movieDirector);

            this.DbContext.Movies.Add(movie);
            this.DbContext.SaveChanges();

            return $"Successfully created a new Theater with ID {movie.Id}!";
        }
    }
}
