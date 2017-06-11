using MovieTheater.Models;
using MovieTheater.Models.Factory;
using System.Web.Script.Serialization;

namespace MovieTheater.Framework.Core.Providers
{
    public class JsonParser
    {
        private string jsonString; 

        public JsonParser(string jsonString)
        {
            this.jsonString = jsonString;
        }

        public Theater Parse()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var d = serializer.Deserialize<Theater>(jsonString);
            var modelsFactory = new ModelsFactory();

            return modelsFactory.CreateTheater(d.Name, d.City, d.Users);
        }
    }
}