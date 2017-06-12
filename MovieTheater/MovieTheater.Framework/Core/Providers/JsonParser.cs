using System.Web.Script.Serialization;
using MovieTheater.Models;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Core.Providers
{
    public class JsonParser
    {
        public JsonParser(string jsonString, IModelsFactory modelsFactory)
        {
            this.JsonString = jsonString;
            this.ModelFactory = modelsFactory;
        }

        public string JsonString { get; private set; }

        public IModelsFactory ModelFactory { get; private set; }

        public Theater Parse()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var deserializer = serializer.Deserialize<Theater>(this.JsonString);

            return this.ModelFactory.CreateTheater(deserializer.Name, deserializer.City, deserializer.Users);
        }
    }
}