namespace MovieTheater.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public short Year { get; set; }

        public virtual Theater Theater { get; set; }


    }
}