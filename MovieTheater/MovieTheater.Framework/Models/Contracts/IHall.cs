namespace MovieTheater.Framework.Models.Contracts
{
    public interface IHall
    {
        int Id { get; set; }

        int HallNumber { get; set; }

        int Seats { get; set; }
    }
}