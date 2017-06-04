namespace MovieTheater.Models
{
    public class Hall
    {
        public int Id { get; set; }

        public int HallNumber { get; set; }

        public int Seats { get; set; }

        public virtual HallShedules HallShedule { get; set; }

        public virtual Ticket Ticket { get; set; }

        public virtual Theater Theater { get; set; }
    }
}