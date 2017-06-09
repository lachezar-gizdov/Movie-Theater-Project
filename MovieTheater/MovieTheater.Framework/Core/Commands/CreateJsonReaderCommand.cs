using System.Collections.Generic;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Framework.Providers.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateJsonReaderCommand : ICommand
    {
        private IFileProviderFactory fileProviderFactory;

        public CreateJsonReaderCommand(IFileProviderFactory fileProviderFactory)
        {
            this.fileProviderFactory = fileProviderFactory;           
        }

        public string Execute(List<string> parameters)
        {
            var jsonReader = this.fileProviderFactory.CreateJsonReader();
            this.fileProviderFactory.CreateJsonParser(jsonReader);

            return "Successfully read json file!";
        }
    }
}