namespace MovieTheater.Models
{
    public class Hall
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public int Seats { get; set; }

        public HallShedule HallShedule { get; set; }
    }
}