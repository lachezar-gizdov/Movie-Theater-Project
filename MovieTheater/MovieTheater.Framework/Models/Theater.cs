using System;
using MovieTheater.Framework.Models.Contracts;

namespace MovieTheater.Framework.Models
{
    public class Theater : ITheater
    {
        public int Id
        {
            get;

            set;
        }

        public string TheaterName
        {
            get;

            set;
        }
    }
}
