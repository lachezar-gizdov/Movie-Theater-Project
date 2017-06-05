using MovieTheater.Framework.Core.Commands.Contracts;
using System;

namespace MovieTheater.Framework.Core.Commands
{
    public class CommandsFactory : ICommandsFactory
    {
        public ICommand CreateCommandFromString(string commandName)
        {
            throw new NotImplementedException();
        }
    }
}
