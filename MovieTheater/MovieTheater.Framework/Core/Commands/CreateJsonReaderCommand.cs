using System.Collections.Generic;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Framework.Core.Providers;
using MovieTheater.Framework.Core.Providers.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateJsonReaderCommand : ICommand
    {
        private IReader reader;
        private IWriter writer;

        public CreateJsonReaderCommand()
        {
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public string Execute(List<string> parameters)
        {
            var jsonReader = new JsonReader(reader, writer);

            jsonReader.Read();

            return "Successfully read json file!";
        }
    }
}