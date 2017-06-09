namespace DataSQLite.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public short Year { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
