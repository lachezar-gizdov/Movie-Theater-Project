using System.Collections.Generic;

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

        public string FirstName { get; set; }

        public string LastName { get; set; }

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