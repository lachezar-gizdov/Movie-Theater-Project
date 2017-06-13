using MovieTheater.Models;
using System.Data.Entity;

namespace MovieTheater.Data.Contracts
{
    public interface IShopDbContext
    {
        IDbSet<FoodShop> FoodShops { get; set; }

        IDbSet<Food> Foods { get; set; }

        int SaveChanges();
    }
}
