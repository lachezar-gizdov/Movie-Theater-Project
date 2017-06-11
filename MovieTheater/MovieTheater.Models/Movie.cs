using System;
using System.ComponentModel.DataAnnotations;

namespace MovieTheater.Models
{
    public class Movie
    {
        private const short FIRST_FEATURE_FILM_YEAR = 1906;

        private short year;

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
        public virtual Ticket Tickets { get; set; }
    }
}