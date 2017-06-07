using System;
using MovieTheater.Data;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory;

namespace MovieTheater.Framework.Core.Commands
{
    public class CommandsFactory : ICommandsFactory
    {
        private MovieTheaterDbContext dbContext;
        private ModelsFactory factory;

        public CommandsFactory(MovieTheaterDbContext dbContext, ModelsFactory factory)
        {
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
                default:
                    throw new ArgumentException("The passed command is not valid!");
            }
        }
    }
}