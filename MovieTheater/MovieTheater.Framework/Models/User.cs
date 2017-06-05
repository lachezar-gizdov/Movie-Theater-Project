using System;
using MovieTheater.Framework.Models.Contracts;

namespace MovieTheater.Framework.Models
{
    public class User : IUser
    {
        public string FirstName
        {
            get;

            set;
        }

        public int Id
        {
            get;

            set;
        }

        public string LastName
        {
            get;

            set;
        }
    }
}