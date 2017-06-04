namespace MovieTheater.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Hall { get; set; }

        public string MovieTitle { get; set; }

        public string ProjectionTime { get; set; }

        public decimal Price { get; set; }
        
        public int Seat { get; set; }  
    }
}