using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTheater.Models
{
    public class User
    {
        private ICollection<Ticket> purchasedTickets;

        public User()
        {
            this.purchasedTickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public City City { get; set; }

        public virtual Theater Theater { get; set; }

        public virtual ICollection<Ticket> PurchasedTickets
        {
            get
            {
                return this.purchasedTickets;
            }

            set
            {
                this.purchasedTickets = value;
            }
        }
    }
}