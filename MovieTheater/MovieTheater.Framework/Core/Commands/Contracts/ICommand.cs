using System.Collections.Generic;

namespace MovieTheater.Framework.Core.Commands.Contracts
{
    public interface ICommand
    {
        string Execute(List<string> parameters);
    }
}