using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core.Commands;
using System;
using System.Linq;

namespace MovieTheater.Framework.Common
{
    public class CommandParser : IParser
    {
        private CommandsFactory factory;

        public CommandParser(CommandsFactory factory)
        {
            this.factory = factory;
        }

        public string Process(string fullCommand)
        {
            if (string.IsNullOrWhiteSpace(fullCommand))
            {
                throw new Exception("No command has been provided!");
            }

            var command = this.factory.CreateCommandFromString(fullCommand.Split(' ')[0]);
            return command.Execute(fullCommand.Split(' ').Skip(1).ToList());
        }
    }
}
