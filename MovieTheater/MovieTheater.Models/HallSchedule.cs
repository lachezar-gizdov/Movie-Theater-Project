using System;
using System.Collections.Generic;

namespace MovieTheater.Models
{
    public class HallSchedule
    {
        private ICollection<Ticket> tickets;

        public HallSchedule()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }

        public ICollection<Ticket> Tickets{
            get
            {
                return this.tickets;
            }
            set
            {
                this.tickets = value;
            }
        }

        public DateTime ProjectionTime { get; set; }
    }
}