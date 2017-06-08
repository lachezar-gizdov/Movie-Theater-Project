using System;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core.Providers;
using MovieTheater.Framework.Core.Providers.Contracts;

namespace MovieTheater.Framework.Common
{
    public class FileReaderFactory : IFileReaderFactory
    {
        private IReader reader;
        private IWriter writer;

        public FileReaderFactory(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public string CreateJsonReader()
        {
            var jsonReader = new JsonReader(reader, writer);
            string jsonString = jsonReader.Read();

            return jsonString;
        }
    }
}