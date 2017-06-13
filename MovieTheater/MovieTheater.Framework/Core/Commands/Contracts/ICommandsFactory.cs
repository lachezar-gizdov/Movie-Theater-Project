namespace MovieTheater.Framework.Core.Commands.Contracts
{
    public interface ICommandsFactory
    {
        ICommand CreateCommandFromString(string commandName);
    }
}
