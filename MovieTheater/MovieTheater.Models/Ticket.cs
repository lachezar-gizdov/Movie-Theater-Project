using System.Collections.Generic;

namespace MovieTheater.Models
{
    public class Ticket
    {
        private ICollection<Hall> hall;


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

        public string MovieTitle { get; set; }

        public string ProjectionTime { get; set; }

        public decimal Price { get; set; }
        
        public int Seat { get; set; }  
    }
}