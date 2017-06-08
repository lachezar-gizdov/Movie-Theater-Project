using System;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core.Providers;
using MovieTheater.Framework.Core.Providers.Contracts;

namespace MovieTheater.Framework.Common
{
    public class FileReaderFactory : IFileReaderFactory
    {
        public string CreateJsonReader(IReader reader, IWriter writer)
        {
            var jsonReader = new JsonReader(reader, writer);
            string jsonString = jsonReader.Read();

            return jsonString;
        }
    }
}