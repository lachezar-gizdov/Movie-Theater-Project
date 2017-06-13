using System;
using Bytes2you.Validation;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core.Commands.Common;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Framework.Providers.Contracts;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CommandsFactory : ICommandsFactory
    {
        private const string DbContextCheck = "Commands Factory DbContext";
        private const string ModelsFactoryCheck = "Commands Factory Models Factory";
        private const string ExporterCheck = "Commands Factory Exporter";
        private const string FileProviderFactoryCheck = "Commands Factory File Provider Factory";
        private readonly IMovieTheaterDbContext dbContext;
        private readonly IModelsFactory modelsFactory;
        private readonly IExporter exporter;
        private IFileProviderFactory fileProviderFactory;

        public CommandsFactory(IMovieTheaterDbContext dbContext, IModelsFactory factory, IExporter exporter, IFileProviderFactory fileProviderFactory)
        {
            Guard.WhenArgument(dbContext, DbContextCheck).IsNull().Throw();
            Guard.WhenArgument(factory, ModelsFactoryCheck).IsNull().Throw();
            Guard.WhenArgument(exporter, ExporterCheck).IsNull().Throw();
            Guard.WhenArgument(fileProviderFactory, FileProviderFactoryCheck).IsNull().Throw();

            this.dbContext = dbContext;
            this.modelsFactory = factory;
            this.exporter = exporter;
            this.fileProviderFactory = fileProviderFactory;
        }

        public ICommand CreateCommandFromString(string commandName)
        {
            string command = commandName.ToLower();

            switch (command)
            {
                case "intro":
                    return new DisplayIntroTextCommand(this.dbContext, this.modelsFactory);
                case "help":
                    return new DisplayHelpCommand(this.dbContext, this.modelsFactory);
                case "createtheater":
                    return new CreateTheaterCommand(this.dbContext, this.modelsFactory);
                case "createhall":
                    return new CreateHallCommand(this.dbContext, this.modelsFactory);
                case "createuser":
                    return new CreateUserCommand(this.dbContext, this.modelsFactory);
                case "createpdfreport":
                    return new CreatePdfReportCommand(this.dbContext, this.modelsFactory, this.exporter);             
                case "readjson":
                    return new CreateJsonReaderCommand(this.fileProviderFactory, this.dbContext, this.modelsFactory);
                default:
                    throw new ArgumentException("The passed command is not valid!");
            }
        }
    }
}