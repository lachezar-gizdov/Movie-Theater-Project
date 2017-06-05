using System;
using MovieTheater.Framework.Models.Contracts;

namespace MovieTheater.Framework.Models
{
    public class Movie : IMovie
    {
        public int Id
        {
            get;

            set;
        }

        public string Name
        {
            get;

            set;
        }

        public short Year
        {
            get;

            set;
        }
    }
}