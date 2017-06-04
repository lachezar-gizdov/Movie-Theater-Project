namespace MovieTheater.Models
{
    public class Hall
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public int Seats { get; set; }

        public HallShedules HallShedule { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}