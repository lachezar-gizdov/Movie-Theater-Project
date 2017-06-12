using System.Collections.Generic;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Framework.Providers.Contracts;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateJsonReaderCommand : Command, ICommand
    {
        private IFileProviderFactory fileProviderFactory;

        public CreateJsonReaderCommand(IFileProviderFactory fileProviderFactory, IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory)
            : base(dbContext, modelsFactory)
        {
            this.fileProviderFactory = fileProviderFactory;
        }

        public override string Execute(List<string> parameters)
        {
            var jsonReader = this.fileProviderFactory.CreateJsonReader();
            var jsonString = jsonReader.Read();

            var theater = this.fileProviderFactory.CreateJsonParser(jsonString);

            this.DbContext.Theaters.Add(theater);
            this.DbContext.SaveChanges();

            return "Successfully read json file!";
        }
    }
}