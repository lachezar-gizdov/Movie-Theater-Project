using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTheater.Models
{
    public class Movie
    {
        private readonly short FIRST_FEATURE_FILM_YEAR;

        private short year;

        private short duration;

        private ICollection<Ticket> tickets;

        public Movie()
        {
            this.FIRST_FEATURE_FILM_YEAR = 1906;
            this.tickets = new HashSet<Ticket>();
        }

        public int Id { get; private set; }

        public string Title { get; private set; }

        public string Director { get; private set; }

        public short Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot have a non-positive movie duration!");
                }

                this.duration = value;
            }
        }

        public short Year
        {
            get
            {
                return this.year;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot have a non-positive year!");
                }
                else if (value < FIRST_FEATURE_FILM_YEAR)
                {
                    throw new ArgumentException("The entered date precedes any known feature films!");
                }
                else
                {
                    this.year = value;
                }
            }
        }

        [Required]
        public virtual ICollection<Ticket> Tickets
        {
            get
            {
                return this.tickets;
            }
            private set
            {
                this.tickets = value;
            }
        }
    }
}