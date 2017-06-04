using System;
using System.Collections.Generic;

namespace MovieTheater.Models
{
    public class Ticket
    {
        private ICollection<Hall> hall;
        private ICollection<Movie> movieTitle;

        private decimal price;

        public int Id { get; set; }

        public virtual ICollection<Hall> Hall
        {
            get
            {
                return this.hall;
            }

            private set
            {
                this.hall = value;
            }
        }

        public virtual ICollection<Movie> MovieTitle
        {
            get
            {
                return this.movieTitle;
            }

            private set
            {
                this.movieTitle = value;
            }
        }

        public string ProjectionTime { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("The price cannot be zero or negative!");
                }

                this.price = value;
            }
        }

        public int Seat { get; set; }
    }
}