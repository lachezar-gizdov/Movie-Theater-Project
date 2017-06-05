using System;
using MovieTheater.Framework.Models.Contracts;

namespace MovieTheater.Framework.Models
{
    public class Hall : IHall
    {
        public int HallNumber
        {
            get;

            set;
        }

        public int Id
        {
            get;

            set;
        }

        public int Seats
        {
            get;

            set;
        }
    }
}