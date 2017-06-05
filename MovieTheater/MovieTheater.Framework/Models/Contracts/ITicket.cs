namespace MovieTheater.Framework.Models.Contracts
{
    public interface ITicket
    {
        decimal Price { get; set; }

        int Id { get; set; }

        int Seat { get; set; }
    }
}