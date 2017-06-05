namespace MovieTheater.Framework.Models.Contracts
{
    public interface ITheater
    {
        int Id { get; set; }

        string TheaterName { get; set; }
    }
}