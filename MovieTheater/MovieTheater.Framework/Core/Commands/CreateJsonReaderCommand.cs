using System.Collections.Generic;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Framework.Core.Providers;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core.Providers.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateJsonReaderCommand : ICommand
    {
        private IFileReaderFactory fileReaderFactory;
        private IReader reader;
        private IWriter writer;

        public CreateJsonReaderCommand(IFileReaderFactory fileReader, IReader reader, IWriter writer)
        {
            this.fileReaderFactory = fileReader;
            this.reader = reader;
            this.writer = writer;
        }

        public string Execute(List<string> parameters)
        {
            var jsonReader = this.fileReaderFactory.CreateJsonReader();

            return "Successfully read json file!";
        }
    }
}