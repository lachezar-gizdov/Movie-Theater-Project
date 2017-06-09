using System;
using System.Collections.Generic;
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

        public void Parse()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<string[]> data = serializer.Deserialize<List<string[]>>(this.jsonString);

            switch (this.jsonString)
            {
                case "":

                default:
                    throw new ArgumentException("The passed JSON is not valid!");
            }
        }
    }
}