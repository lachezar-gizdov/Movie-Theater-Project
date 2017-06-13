using System;
using Bytes2you.Validation;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core.Commands.Common;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Framework.Providers.Contracts;
using MovieTheater.Models.Factory.Contracts;
using MovieTheater.Framework.Core.Commands.CreateCommands;
using MovieTheater.Framework.Core.Commands.DeleteCommands;

namespace MovieTheater.Framework.Core.Commands
{
    public class CommandsFactory : ICommandsFactory
    {
        private const string DbContextCheck = "Commands Factory DbContext";
        private const string ModelsFactoryCheck = "Commands Factory Models Factory";
        private const string ExporterCheck = "Commands Factory Exporter";
        private const string FileProviderFactoryCheck = "Commands Factory File Provider Factory";
        private readonly IMovieTheaterDbContext moviesDbContext;
        private readonly IStaffDbContext staffDbContext;
        private readonly IShopDbContext shopDbContext;
        private readonly IModelsFactory modelsFactory;
        private readonly IExporter exporter;
        private IFileProviderFactory fileProviderFactory;

        public CommandsFactory(IMovieTheaterDbContext movieDbContext, IStaffDbContext staffDbContext, IShopDbContext shopDbContext,
            IModelsFactory factory, IExporter exporter, IFileProviderFactory fileProviderFactory)
        {
            Guard.WhenArgument(movieDbContext, DbContextCheck).IsNull().Throw();
            Guard.WhenArgument(factory, ModelsFactoryCheck).IsNull().Throw();
            Guard.WhenArgument(exporter, ExporterCheck).IsNull().Throw();
            Guard.WhenArgument(fileProviderFactory, FileProviderFactoryCheck).IsNull().Throw();

            this.moviesDbContext = movieDbContext;
            this.modelsFactory = factory;
            this.staffDbContext = staffDbContext;
            this.shopDbContext = shopDbContext;
            this.exporter = exporter;
            this.fileProviderFactory = fileProviderFactory;
        }

        public ICommand CreateCommandFromString(string commandName)
        {
            string command = commandName.ToLower();

            switch (command)
            {
                case "intro":
                    return new DisplayIntroTextCommand(this.moviesDbContext, this.modelsFactory);
                case "help":
                    return new DisplayHelpCommand(this.moviesDbContext, this.modelsFactory);
                case "createtheater":
                    return new CreateTheaterCommand(this.moviesDbContext, this.modelsFactory);
                case "createhall":
                    return new CreateHallCommand(this.moviesDbContext, this.modelsFactory);
                case "createschedule":
                    return new CreateHallScheduleCommand(this.moviesDbContext, this.modelsFactory);
                case "createmovie":
                    return new CreateMovieCommand(this.moviesDbContext, this.modelsFactory);
                case "createuser":
                    return new CreateUserCommand(this.moviesDbContext, this.modelsFactory);
                case "createticket":
                    return new CreateTicketCommand(this.moviesDbContext, this.modelsFactory);
                case "createpdfreport":
                    return new CreatePdfReportCommand(this.moviesDbContext, this.modelsFactory, this.exporter);
                case "deleteuser":
                    return new DeleteUserCommand(this.moviesDbContext, this.modelsFactory);
                case "readjson":
                    return new CreateJsonReaderCommand(this.fileProviderFactory, this.moviesDbContext, this.modelsFactory);
                case "createstaffmember":
                    return new CreateStaffMember(this.staffDbContext, this.modelsFactory);
                case "createshop":
                    return new CreateShopCommand(this.shopDbContext, this.modelsFactory);
                default:
                    throw new ArgumentException("The passed command is not valid!");
            }
        }
    }
}