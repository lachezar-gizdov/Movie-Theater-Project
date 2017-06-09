using System;
using Bytes2you.Validation;
using MovieTheater.Data;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;
using MovieTheater.Framework.Providers.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CommandsFactory : ICommandsFactory
    {
        private readonly MovieTheaterDbContext dbContext;
        private readonly IModelsFactory factory;
        private readonly IExporter exporter;
        private IFileProviderFactory fileProviderFactory;

        public CommandsFactory(MovieTheaterDbContext dbContext, IModelsFactory factory, IExporter exporter, IFileProviderFactory fileProviderFactory)
        {
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();
            Guard.WhenArgument(factory, "Models Factory").IsNull().Throw();

            this.dbContext = dbContext;
            this.factory = factory;
            this.exporter = exporter;
            this.fileProviderFactory = fileProviderFactory;
        }

        public ICommand CreateCommandFromString(string commandName)
        {
            string command = commandName.ToLower();

            switch (command)
            {
                case "createtheater":
                    return new CreateTheaterCommand(this.dbContext, this.factory);
                case "createuser":
                    return new CreateUserCommand(this.dbContext, this.factory);
                case "createpdfreport":
                    return new CreatePdfReportCommand(this.dbContext, this.exporter);
                case "readjson":
                    return new CreateJsonReaderCommand(this.fileProviderFactory);
                default:
                    throw new ArgumentException("The passed command is not valid!");
            }
        }
    }
}