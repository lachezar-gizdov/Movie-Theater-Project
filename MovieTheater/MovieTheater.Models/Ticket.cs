using System;
using System.ComponentModel.DataAnnotations;

namespace MovieTheater.Models
{
    public class Ticket
    {
        private decimal price;

        private short projectionTime;

        [Required]
        public int Id { get; set; }

        [Required]
        public virtual Movie Movie { get; set; }

        [Required]
        public virtual HallSchedule HallSchedule { get;  set; }

        // Projection time format: 1700 is the same as 17:00, 1115 is the same as 11:15, etc
        public short ProjectionTime
        {
            get
            {
                return this.projectionTime;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The projection time cannot be negative!");
                }
            }
        }

        [Required]
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The price cannot be zero or negative!");
                }

                this.price = value;
            }
        }

        [Required]
        public virtual User User { get; set; }

        [Required]
        public virtual int Seat { get; set; }
    }
}