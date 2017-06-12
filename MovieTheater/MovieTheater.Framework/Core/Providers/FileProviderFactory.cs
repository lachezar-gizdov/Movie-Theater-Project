using MovieTheater.Framework.Core.Providers;
using MovieTheater.Framework.Core.Providers.Contracts;
using MovieTheater.Framework.Providers.Contracts;
using MovieTheater.Models;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Providers
{
    public class FileProviderFactory : IFileProviderFactory
    {
        private IReader reader;
        private IWriter writer;
        private IModelsFactory modelsFactory;

        public FileProviderFactory(IReader reader, IWriter writer, IModelsFactory modelsFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.modelsFactory = modelsFactory;
        }
    
        public JsonReader CreateJsonReader()
        {
            var jsonReader = new JsonReader(this.reader, this.writer);

            return jsonReader;
        }

        public Theater CreateJsonParser(string jsonString)
        {
            var jsonParser = new JsonParser(jsonString, this.modelsFactory);
            var theater = jsonParser.Parse();

            return theater;
        }
    }
}