using System;
using Bytes2you.Validation;
using MovieTheater.Data;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CommandsFactory : ICommandsFactory
    {
        private MovieTheaterDbContext dbContext;
        private readonly IModelsFactory factory;

        public CommandsFactory(MovieTheaterDbContext dbContext, IModelsFactory factory)
        {
            Guard.WhenArgument(dbContext, "dbContext").IsNull().Throw();
            Guard.WhenArgument(factory, "Models Factory").IsNull().Throw();

            this.dbContext = dbContext;
            this.factory = factory;
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
                case "createjsonreader":
                    return new CreateJsonReaderCommand();
                default:
                    throw new ArgumentException("The passed command is not valid!");
            }
        }
    }
}