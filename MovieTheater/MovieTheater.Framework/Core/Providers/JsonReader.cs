using System.IO;
using MovieTheater.Framework.Core.Providers.Contracts;

namespace MovieTheater.Framework.Core.Providers
{
    public class JsonReader : IReader
    {
        public JsonReader(IReader reader, IWriter writer)
        {
            this.Reader = reader;
            this.Writer = writer;
        }

        public IReader Reader { get; private set; }

        public IWriter Writer { get; private set; }

        public string Read()
        {
            this.Writer.Write("Enter path of JSON file:");
            string path = this.Reader.Read();

            StreamReader readJson = new StreamReader($@"{path}");
            string jsonString = readJson.ReadToEnd();

            return jsonString;
        } 
    }
}