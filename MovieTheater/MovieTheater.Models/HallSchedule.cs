using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        public string Number { get; set; }

        [Required]
        public virtual Hall Hall { get; set; }

        public string ProjectionTime { get; set; }

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
    }
}