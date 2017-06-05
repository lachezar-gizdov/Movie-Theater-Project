using System;
using MovieTheater.Framework.Models.Contracts;

namespace MovieTheater.Framework.Models
{
    public class Ticket : ITicket
    {
        public int Id
        {
            get;

            set;
        }

        public decimal Price
        {
            get;

            set;
        }

        public int Seat
        {
            get;

            set;
        }
    }
}