using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;

namespace MovieTheater.Framework.Core.Providers
{
    public class JsonParser
    {
        private string jsonString; 

        public JsonParser(string jsonString)
        {
            this.jsonString = jsonString;
        }

        public void Parse()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<string[]> data = serializer.Deserialize<List<string[]>>(jsonString);

            switch (this.jsonString)
            {
                case "":

                default:
                    throw new ArgumentException("The passed JSON is not valid!");
            }
        }
    }
}