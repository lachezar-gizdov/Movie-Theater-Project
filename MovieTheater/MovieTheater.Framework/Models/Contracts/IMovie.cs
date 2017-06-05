namespace MovieTheater.Framework.Models.Contracts
{
    public interface IMovie
    {
        int Id { get; set; }

        string Name { get; set; }

        short Year { get; set; }
    }
}