using System.Collections.Generic;

namespace MovieTheater.Models
{ 
    public class Hall
    {
        private ICollection<Seat> seats;
        private ICollection<HallSchedule> hallSchedules;

        public Hall()
        {
            this.Seats = new HashSet<Seat>();
            this.HallSchedules = new HashSet<HallSchedule>();
        }

        public int Id { get; set; }

        public virtual ICollection<Seat> Seats{
            get
            {
                return this.seats;
            }
            set
            {
                this.seats = value;
            }
        }

        public virtual ICollection<HallSchedule> HallSchedules
        {
            get
            {
                return this.hallSchedules;
            }
            set
            {
                this.hallSchedules = value;
            }
        }
    }
}