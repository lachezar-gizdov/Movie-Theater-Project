using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTheater.Models
{
    public class Movie
    {
        private readonly short firstFeatureFilmYear;

        private short year;

        private short duration;

        private ICollection<Ticket> tickets;

        public Movie()
        {
            this.firstFeatureFilmYear = 1906;
            this.tickets = new HashSet<Ticket>();
        }

        public int Id { get; private set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public short Duration
        {
            get
            {
                return this.duration;
            }

            set
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

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot have a non-positive year!");
                }
                else if (value < this.firstFeatureFilmYear)
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