using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTheater.Models
{
    public class Movie
    {
        private const short FIRST_FEATURE_FILM_YEAR = 1906;
        private ICollection<Ticket> tickets;
        private short year;

        public Movie()
        {
            this.tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

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
        public virtual Theater Theater { get; set; }

        [Required]
        public virtual ICollection<Ticket> Tickets
        {
            get
            {
                return this.tickets;
            }
            set
            {
                this.tickets = value;
            }
        }
    }
}