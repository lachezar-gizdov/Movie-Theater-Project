using System.Collections.Generic;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Framework.Core.Providers;
using MovieTheater.Framework.Common.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateJsonReaderCommand : ICommand
    {
        private IFileReader fileReader;

        public CreateJsonReaderCommand(IFileReader fileReader)
        {
            this.fileReader = fileReader;
        }

        public string Execute(List<string> parameters)
        {
            var jsonReader = this.fileReader.CreateJsonReader();

            return "Successfully read json file!";
        }
    }
}